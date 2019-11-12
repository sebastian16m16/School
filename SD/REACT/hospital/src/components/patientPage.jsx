import React, { Component } from "react";
import { Table, Button, ButtonToolbar } from "react-bootstrap";
import UpdatePatient from "./Patient/updatePatient";
import AddPatient from "./Patient/addPatient";
import DeletePatient from "./Patient/deletePatient";

class PatientPage extends Component {
  constructor(props) {
    super(props);
    this.state = {
      Patients: [],
      addModalShow: false,
      editModelShow: false,
      deleteModalShow: false
    };
  }

  componentDidMount() {
    this.refreshList();
  }
  componentDidUpdate() {
    this.refreshList();
  }

  refreshList() {
    fetch("https://localhost:44379/api/patient")
      .then(res => res.json())
      .then(data => {
        this.setState({ Patients: data });
      });
  }
  render() {
    const {
      Patients,
      id,
      first_name,
      last_name,
      birthdate,
      address,
      gender,
      doctor,
      caregiver,
      medication_plan
    } = this.state;

    let addModalClose = () => this.setState({ addModalShow: false });
    let editModalClose = () => this.setState({ editModalShow: false });
    let deleteModalClose = () => this.setState({ deleteModalShow: false });
    return (
      <div>
        <Table className="mt-4" striped bordered hover size="sm">
          <thead>
            <tr>
              <th>Patient ID</th>
              <th>First Name</th>
              <th>Last Name</th>
              <th>Birthdate</th>
              <th>Address</th>
              <th>Gender</th>
              <th>Doctor</th>
              <th>Caregiver</th>
              <th>Medication Plan</th>
              <th>Options</th>
              <th>Delete</th>
            </tr>
          </thead>
          <tbody>
            {Patients.map(patient => (
              <tr key={patient.id}>
                <td>{patient.id}</td>
                <td>{patient.first_name}</td>
                <td>{patient.last_name}</td>
                <td>{patient.birthdate}</td>
                <td>{patient.address}</td>
                <td>{patient.gender}</td>
                <td>{patient.doctor}</td>
                <td>{patient.caregiver}</td>
                <td>{patient.medication_plan}</td>
                <td>
                  <ButtonToolbar>
                    <Button
                      className="mr-2"
                      variant="info"
                      onClick={() =>
                        this.setState({
                          editModalShow: true,
                          id: patient.id,
                          first_name: patient.first_name,
                          last_name: patient.last_name,
                          birthdate: patient.birthdate,
                          address: patient.address,
                          gender: patient.gender,
                          doctor: patient.doctor,
                          caregiver: patient.caregiver,
                          medication_plan: patient.medication_plan
                        })
                      }
                    >
                      Edit
                    </Button>
                    <UpdatePatient
                      show={this.state.editModalShow}
                      onHide={editModalClose}
                      id={id}
                      first_name={first_name}
                      last_name={last_name}
                      birthdate={birthdate}
                      address={address}
                      gender={gender}
                      doctor={doctor}
                      caregiver={caregiver}
                      medication_plan={medication_plan}
                    />
                  </ButtonToolbar>
                </td>
                <td>
                  <ButtonToolbar>
                    <Button
                      className="btn ml-4"
                      variant="danger"
                      onClick={() =>
                        this.setState({
                          deleteModalShow: true
                        })
                      }
                    >
                      Delete
                    </Button>
                    <DeletePatient
                      show={this.state.deleteModalShow}
                      onHide={deleteModalClose}
                      id={patient.id}
                    />
                  </ButtonToolbar>
                </td>
              </tr>
            ))}
          </tbody>
        </Table>
        <ButtonToolbar>
          <Button
            variant="primary"
            onClick={() => this.setState({ addModalShow: true })}
          >
            Add Patient
          </Button>
          <AddPatient show={this.state.addModalShow} onHide={addModalClose} />
        </ButtonToolbar>
      </div>
    );
  }
}

export default PatientPage;
