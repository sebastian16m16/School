import React from "react";
import "./App.css";
import { Button, Form, FormGroup, Label, Input } from "reactstrap";
import { Login } from "./components/Login/login";
import { BrowserRouter, Route, Switch } from "react-router-dom";
import DoctorPage from "./components/Doctor/doctorPage";
import CaregiverPage from "./components/Caregiver/caregiverPage";
import Navigation from "./components/layout/navigation";

function App() {
  return (
    <BrowserRouter>
      <div className="container">
        <Navigation />
        <Switch>
          <Route path="/" component={Login} exact />
          <Route path="/doctorPage" component={DoctorPage} />
          <Route path="/caregiverPage" component={CaregiverPage} />
        </Switch>
      </div>
    </BrowserRouter>
  );
}

export default App;
