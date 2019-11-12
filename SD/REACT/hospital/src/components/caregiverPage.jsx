import React, { Component } from "react";
import { Table, Button, ButtonToolbar } from "react-bootstrap";
import UpdateCaregiver from "./Caregiver/updateCaregiver";
import AddCaregiver from "./Caregiver/addCaregiver";
import DeleteCaregiver from "./Caregiver/deleteCaregiver";

class CaregiverPage extends Component {
  constructor(props) {
    super(props);
    this.state = {
      Caregivers: [],
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
    fetch("https://localhost:44379/api/caregiver")
      .then(res => res.json())
      .then(data => {
        this.setState({ Caregivers: data });
      });
  }
  render() {
    const {
      Caregivers,
      id,
      first_name,
      last_name,
      birthdate,
      address,
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
              <th>Caregiver ID</th>
              <th>First Name</th>
              <th>Last Name</th>
              <th>Birthdate</th>
              <th>Address</th>
              <th>Gender</th>
              <th>Options</th>
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
                <td>
                  <ButtonToolbar>
                    <Button
                      className="mr-2"
                      variant="info"
                      onClick={() =>
                        this.setState({
                          editModalShow: true,
                          id: caregiver.id,
                          first_name: caregiver.first_name,
                          last_name: caregiver.last_name,
                          birthdate: caregiver.birthdate,
                          address: caregiver.address,
                          gender: caregiver.gender
                        })
                      }
                    >
                      Edit
                    </Button>
                    <UpdateCaregiver
                      show={this.state.editModalShow}
                      onHide={editModalClose}
                      id={id}
                      first_name={first_name}
                      last_name={last_name}
                      birthdate={birthdate}
                      address={address}
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
                    <DeleteCaregiver
                      show={this.state.deleteModalShow}
                      onHide={deleteModalClose}
                      id={caregiver.id}
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
            Add Caregiver
          </Button>
          <AddCaregiver show={this.state.addModalShow} onHide={addModalClose} />
        </ButtonToolbar>
      </div>
    );
  }
}

export default CaregiverPage;
