import logo from './logo.svg';
import './App.css';
import Fetch from './Fetch';
import React  from 'react';
function App() {
  return (
   
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.js</code> and save to reload.
        </p>
          <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
          
        </a>
        <Fetch></Fetch>
      

      </header>

  );
}

export default App;