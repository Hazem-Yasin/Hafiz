import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import Comp from './Comp'

//! _START getting the ayah surah page components
import AyahComp from './Components/AyahComponent/AyahComp'
import SurahComp from './Components/SurahComponent/SurahComp'
import PageComp from './Components/PageComponent/PageComp'
import reportWebVitals from './reportWebVitals';
//! _END getting the ayah surah page components

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
   {/* <App /> */}
  <Comp />
  </React.StrictMode>
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
