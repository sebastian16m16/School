import React, { Component } from "react";
import CaregiverPage from "./caregiverPage";
import Login from "./login";
import PatientPage from "./patientPage";
import MedicationPlanPage from "./medicationPlanPage";
import MedicationPage from "./medicationPage";
import SideEffectPage from "./sideEffectPage";
import DoctorPage from "./doctorPage";

export class MasterPage extends Component {
  constructor(props) {
    super(props);
    this.whatToRender = this.whatToRender.bind(this);
    this.handleChange = this.handleChange.bind(this);
  }

  state = {
    checked: "doctor"
  };

  whatToRender = () => {
    switch (this.state.checked) {
      case "doctor":
        return <DoctorPage />;
      case "caregiver":
        return <CaregiverPage />;
      case "patient":
        return <PatientPage />;
      case "medication_plan":
        return <MedicationPlanPage />;
      case "medication":
        return <MedicationPage />;
      case "side_effect":
        return <SideEffectPage />;
      default:
        return <Login />;
    }
  };

  render() {
    return (
      <div className="container">
        <div onChange={this.setChecked.bind(this)}>
          <input
            type="radio"
            value="doctor"
            name="gender"
            checked={this.state.checked === "doctor"}
            onChange={this.handleChange}
          />{" "}
          Doctors
          <input
            className="ml-4"
            type="radio"
            value="caregiver"
            name="gender"
            checked={this.state.checked === "caregiver"}
            onChange={this.handleChange}
          />{" "}
          Caregivers
          <input
            className="ml-4"
            type="radio"
            value="patient"
            name="gender"
            checked={this.state.checked === "patient"}
            onChange={this.handleChange}
          />{" "}
          Patients
          <input
            className="ml-4"
            type="radio"
            value="medication_plan"
            name="gender"
            checked={this.state.checked === "medication_plan"}
            onChange={this.handleChange}
          />{" "}
          Medication Plans
          <input
            className="ml-4"
            type="radio"
            value="medication"
            name="gender"
            checked={this.state.checked === "medication"}
            onChange={this.handleChange}
          />{" "}
          Medications
          <input
            className="ml-4"
            type="radio"
            value="side_effect"
            name="gender"
            checked={this.state.checked === "side_effect"}
            onChange={this.handleChange}
          />{" "}
          Side Effects
        </div>
        {this.whatToRender()}
      </div>
    );
  }

  //additional methods
  handleRadio = r => {};

  setChecked(event) {
    console.log(event.target.value);
  }

  handleChange(event) {
    this.setState({
      checked: event.target.value
    });
  }
}

export default MasterPage;
