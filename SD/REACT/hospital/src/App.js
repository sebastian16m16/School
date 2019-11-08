import React from "react";
import "./App.css";
import { Button, Form, FormGroup, Label, Input } from "reactstrap";
import { Login } from "./components/login";
import { BrowserRouter, Route, Switch } from "react-router-dom";
import DoctorPage from "./components/doctorPage";
import CaregiverPage from "./components/caregiverPage";
import Navigation from "./components/navigation";

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
