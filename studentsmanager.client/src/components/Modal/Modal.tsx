import { ReactNode } from "react"
import { Portal } from "../Portal/Portal";
import './Modal.css';

interface Modalprops {
    children: ReactNode,
    onClose: () => void,
    isOpen: boolean,
    modalWrapperId: string,
    title: string,
}

export const Modal = ({
    isOpen, children, onClose,
    modalWrapperId, title
}: Modalprops) => {
    if (!isOpen) return null;

    return (
        <Portal wrapperId={modalWrapperId}>
            <div className="modal">
                <div className="modal-content">
                    <div className="modal-header">
                        <div className="modal-title">{title}</div>
                        <button onClick={onClose} className="close-btn">
                            Close
                        </button>
                    </div>
                    {children}
                </div>
            </div>
        </Portal>
    )
}
