import React from "react";
import "./App.css";
import { Login } from "./components/login";
import { BrowserRouter, Route, Switch } from "react-router-dom";
import CaregiverPage from "./components/caregiverPage";
import Navigation from "./components/navigation";
import MasterPage from "./components/masterPage";
import PatientPage from "./components/patientPage";
import MedicationPlanPage from "./components/medicationPlanPage";
import MedicationPage from "./components/medicationPage";
import SideEffectPage from "./components/sideEffectPage";
import DoctorUI from "./components/Doctor/DoctorUI";

function App() {
  return (
    <BrowserRouter>
      <div className="container">
        <Navigation />
        <Switch>
          <Route path="/" component={Login} exact />
          <Route path="/caregiverPage" component={CaregiverPage} />
          <Route path="/doctorPage" component={MasterPage} />
          <Route path="/patientpage" component={PatientPage} />
          <Route path="/medicationPlanPage" component={MedicationPlanPage} />
          <Route path="/medicationPage" component={MedicationPage} />
          <Route path="/sideEffectPage" component={SideEffectPage} />
          <Route path="/doctorUI" component={DoctorUI} />
        </Switch>
      </div>
    </BrowserRouter>
  );
}

export default App;
