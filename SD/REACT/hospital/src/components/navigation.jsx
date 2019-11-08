import React, { Component } from "react";
import { NavLink } from "react-router-dom";
import { Navbar, Nav } from "react-bootstrap";

class Navigation extends Component {
  state = {};
  render() {
    return (
      <Navbar bg="dark" expand="lg">
        <Navbar.Toggle aria-controls="basic-navbar-nav" />
        <Navbar.Collapse id="basic-navbar-nav" />
        <Nav></Nav>
        <NavLink className="d-inline p-2 bg-dark text-white" to="/">
          Login
        </NavLink>
        <NavLink className="d-inline p-2 bg-dark text-white" to="/doctorPage">
          Doctors Page
        </NavLink>
        <NavLink
          className="d-inline p-2 bg-dark text-white"
          to="/caregiverPage"
        >
          Caregivers Page
        </NavLink>
      </Navbar>
    );
  }
}

export default Navigation;
