import React from 'react'
import ReactDOM from 'react-dom/client'
import ReactComponent from './ReactComponent.tsx'
import SurahComponent from './Components/SurahComp/SurahComponent.tsx'

ReactDOM.createRoot(document.getElementById('root')!).render(
    <React.StrictMode>
        <ReactComponent />
        <SurahComponent />
    </React.StrictMode>,
)
