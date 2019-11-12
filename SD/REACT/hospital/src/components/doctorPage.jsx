import React, { Component } from "react";
import { Table, Button, ButtonToolbar } from "react-bootstrap";
import { PopUpAddDoc } from "./Doctor/AddDoctorPopUp";
import { UpdateDoctor } from "./Doctor/UpdateDoctor";
import { DeleteDoctor } from "./Doctor/deleteDoctor";

class DoctorPage extends Component {
  constructor(props) {
    super(props);
    this.state = {
      doctors: [],
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
    fetch("https://localhost:44379/api/doctor")
      .then(response => response.json())
      .then(data => {
        this.setState({ doctors: data });
      });
  }

  render() {
    const {
      doctors,
      id,
      first_name,
      last_name,
      birthdate,
      address,
      medical_record,
      gender
    } = this.state;
    let addModalClose = () => this.setState({ addModalShow: false });
    let editModalClose = () => this.setState({ editModalShow: false });
    let deleteModalClose = () => this.setState({ deleteModalShow: false });
    return (
      <div>
        <Table className="mt-4" striped bordered hover size="sm">
          <thead>
            <tr>
              <th>Doctor ID</th>
              <th>First Name</th>
              <th>Last Name</th>
              <th>Birthdate</th>
              <th>Medical Record</th>
              <th>Address</th>
              <th>Gender</th>
              <th>Edit</th>
              <th>Delete</th>
            </tr>
          </thead>
          <tbody>
            {doctors.map(doctor => (
              <tr key={doctor.id}>
                <td>{doctor.id}</td>
                <td>{doctor.first_name}</td>
                <td>{doctor.last_name}</td>
                <td>{doctor.birthdate}</td>
                <td>{doctor.medical_record}</td>
                <td>{doctor.address}</td>
                <td>{doctor.gender}</td>
                <td>
                  <ButtonToolbar>
                    <Button
                      className="btn mr-4"
                      variant="info"
                      onClick={() =>
                        this.setState({
                          editModalShow: true,
                          id: doctor.id,
                          first_name: doctor.first_name,
                          last_name: doctor.last_name,
                          birthdate: doctor.birthdate,
                          medical_record: doctor.medical_record,
                          address: doctor.address,
                          gender: doctor.gender
                        })
                      }
                    >
                      Edit
                    </Button>

                    <UpdateDoctor
                      show={this.state.editModalShow}
                      onHide={editModalClose}
                      id={id}
                      first_name={first_name}
                      last_name={last_name}
                      birthdate={birthdate}
                      address={address}
                      medical_record={medical_record}
                      gender={gender}
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
                    <DeleteDoctor
                      show={this.state.deleteModalShow}
                      onHide={deleteModalClose}
                      id={doctor.id}
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
            Add Doctor
          </Button>
          <PopUpAddDoc show={this.state.addModalShow} onHide={addModalClose} />
        </ButtonToolbar>
      </div>
    );
  }
}

export default DoctorPage;
