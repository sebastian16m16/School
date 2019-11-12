import React, { Component } from "react";
import { Table, Button, ButtonToolbar } from "react-bootstrap";
import UpdateMedication from "./Medication/updateMedication";
import AddMedication from "./Medication/addMedication";
import DeleteMedication from "./Medication/deleteMedication";

class MedicationPage extends Component {
  constructor(props) {
    super(props);
    this.state = {
      Medications: [],
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
    fetch("https://localhost:44379/api/medication")
      .then(res => res.json())
      .then(data => {
        this.setState({ Medications: data });
      });
  }
  render() {
    const { Medications, id, name, side_effect, dosage } = this.state;

    let addModalClose = () => this.setState({ addModalShow: false });
    let editModalClose = () => this.setState({ editModalShow: false });
    let deleteModalClose = () => this.setState({ deleteModalShow: false });
    return (
      <div>
        <Table className="mt-4" striped bordered hover size="sm">
          <thead>
            <tr>
              <th>Medication ID</th>
              <th>Name</th>
              <th>Side Effect</th>
              <th>Dosage</th>
              <th>Options</th>
              <th>Delete</th>
            </tr>
          </thead>
          <tbody>
            {Medications.map(medication => (
              <tr key={medication.id}>
                <td>{medication.id}</td>
                <td>{medication.name}</td>
                <td>{medication.side_effect}</td>
                <td>{medication.dosage}</td>
                <td>
                  <ButtonToolbar>
                    <Button
                      className="mr-2"
                      variant="info"
                      onClick={() =>
                        this.setState({
                          editModalShow: true,
                          id: medication.id,
                          name: medication.name,
                          side_effect: medication.side_effect,
                          dosage: medication.dosage
                        })
                      }
                    >
                      Edit
                    </Button>
                    <UpdateMedication
                      show={this.state.editModalShow}
                      onHide={editModalClose}
                      id={id}
                      name={name}
                      medication={side_effect}
                      assigned_by={dosage}
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
                    <DeleteMedication
                      show={this.state.deleteModalShow}
                      onHide={deleteModalClose}
                      id={medication.id}
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
            Add Medication
          </Button>
          <AddMedication
            show={this.state.addModalShow}
            onHide={addModalClose}
          />
        </ButtonToolbar>
      </div>
    );
  }
}

export default MedicationPage;
