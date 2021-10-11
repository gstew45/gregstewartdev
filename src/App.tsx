import React from 'react';
import logo from './logo.svg';
import Home from './Home';
import './App.css';
import { render } from '@testing-library/react';

function App(): React.ReactNode {
  return (
    <div>
      <Home />
    </div>
  );
}

export default App;
