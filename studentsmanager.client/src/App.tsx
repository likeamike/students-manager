import './App.css';
import { GreetingsBlock } from './components/GreetingsBlock/GreetingsBlock';
import { StudentsTable } from './components/StudentsTable/StudentsTable';

function App() {
    return (
        <div className='students-manager'>
            <h1 className='page-header' id="tabelLabel">
                <span>Students</span>
                <span> manager</span>
            </h1>
            <GreetingsBlock />            
            <StudentsTable />
        </div>
    );
}

export default App;
