import React, { Component } from "react";
import { Table } from "react-bootstrap";

class CaregiverPage extends Component {
  constructor(props) {
    super(props);
    this.state = { Caregivers: [] };
  }

  componentDidMount() {
    this.refreshList();
  }

  refreshList() {
    fetch("https://localhost:44379/api/caregiver")
      .then(res => res.json())
      .then(data => {
        this.setState({ Caregivers: data });
      });
  }
  render() {
    const { Caregivers } = this.state;
    return (
      <Table className="mt-4" striped bordered hover size="sm">
        <thead>
          <tr>
            <th>Caregiver ID</th>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Birthdate</th>
            <th>Address</th>
            <th>Gender</th>
          </tr>
        </thead>
        <tbody>
          {Caregivers.map(caregiver => (
            <tr key={caregiver.id}>
              <td>{caregiver.id}</td>
              <td>{caregiver.first_name}</td>
              <td>{caregiver.last_name}</td>
              <td>{caregiver.birthdate}</td>
              <td>{caregiver.address}</td>
              <td>{caregiver.gender}</td>
            </tr>
          ))}
        </tbody>
      </Table>
    );
  }
}

export default CaregiverPage;
