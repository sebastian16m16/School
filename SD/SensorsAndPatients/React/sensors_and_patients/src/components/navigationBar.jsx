import React, { Component } from "react";
import { NavLink } from "react-router-dom";
import { Navbar } from "react-bootstrap";

class NavigationBar extends Component {
  state = {};
  render() {
    return (
      <Navbar title="This" bg="secondary" expand="lg">
        <Navbar.Brand href="#home">Sensors & Patients</Navbar.Brand>
        <Navbar.Toggle aria-controls="basic-navbar-nav" />
        <Navbar.Collapse id="basic-navbar-nav" />

        <NavLink
          id="home"
          className="d-inline p-2 inactive"
          activeClassName="active"
          to="/"
        >
          HOME
        </NavLink>

        <NavLink
          id="activities"
          className="d-inline p-2 inactive"
          activeClassName="active"
          to="/activities"
        >
          Activities
        </NavLink>

        <NavLink
          id="caregiver"
          className="d-inline p-2 inactive"
          activeClassName="active"
          to="/notifications"
        >
          Notifications
        </NavLink>
      </Navbar>
    );
  }
}

export default NavigationBar;
