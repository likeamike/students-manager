import { ReactNode, useLayoutEffect, useState } from "react";
import { createPortal } from "react-dom";

interface PortalProps {
    children: ReactNode,
    wrapperId: string,
}

export const Portal = ({ children, wrapperId = "students-manager-portal-wrapper" }: PortalProps) => {
    const [wrapper, setWrapper] = useState<HTMLElement | null>(null);

    useLayoutEffect(() => {
        let element = document.getElementById(wrapperId);
        let isCreated = false;

        if (!element) {
            isCreated = true;
            element = createWrapperAndAppendToBody(wrapperId);
        }

        setWrapper(element);

        return () => {
            if (isCreated && element?.parentNode) {
                element.parentNode.removeChild(element);
            }
        }
    }, [wrapperId])

    if (wrapper === null)
        return null;

    return createPortal(children, wrapper);
}

const createWrapperAndAppendToBody = (wrapperId: string): HTMLDivElement => {
    const wrapperElement = document.createElement('div');
    wrapperElement.setAttribute("id", wrapperId);
    document.body.appendChild(wrapperElement);
    return wrapperElement;
}
