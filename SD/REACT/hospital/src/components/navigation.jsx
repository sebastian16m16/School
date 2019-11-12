import React, { Component } from "react";
import { NavLink } from "react-router-dom";
import { Navbar } from "react-bootstrap";

class Navigation extends Component {
  state = {};
  render() {
    return (
      <Navbar bg="dark" expand="lg">
        <Navbar.Toggle aria-controls="basic-navbar-nav" />
        <Navbar.Collapse id="basic-navbar-nav" />

        <NavLink className="d-inline p-2 bg-dark text-white" to="/">
          Login
        </NavLink>

        <NavLink className="d-inline p-2 bg-dark text-white" to="/doctorPage">
          MasterPage
        </NavLink>

        <NavLink className="d-inline p-2 bg-dark text-white" to="/doctorUI">
          Doctor UI
        </NavLink>

        <NavLink
          className="d-inline p-2 bg-dark text-white"
          to="/caregiverPage"
        >
          Caregivers Page
        </NavLink>

        <NavLink className="d-inline p-2 bg-dark text-white" to="/patientPage">
          Patients
        </NavLink>

        <NavLink
          className="d-inline p-2 bg-dark text-red"
          to="/medicationPlanPage"
        >
          Medication Plans
        </NavLink>

        <NavLink className="d-inline p-2 bg-dark text-red" to="/medicationPage">
          Medications
        </NavLink>
        <NavLink className="d-inline p-2 bg-dark text-red" to="/sideEffectPage">
          Side Effects
        </NavLink>
      </Navbar>
    );
  }
}

export default Navigation;
