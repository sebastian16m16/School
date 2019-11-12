import React, { Component } from "react";
import { Table, Button, ButtonToolbar } from "react-bootstrap";
import UpdateMedicationPlan from "./MedicationPlan/updateMedicationPlan";
import AddMedicationPlan from "./MedicationPlan/addMedicationPlan";
import DeleteMedicationPlan from "./MedicationPlan/deleteMedicationPlan";

class MedicationPlanPage extends Component {
  constructor(props) {
    super(props);
    this.state = {
      Plans: [],
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
    fetch("https://localhost:44379/api/medicationplan")
      .then(res => res.json())
      .then(data => {
        this.setState({ Plans: data });
      });
  }
  render() {
    const { Plans, id, name, medication, assigned_by } = this.state;

    let addModalClose = () => this.setState({ addModalShow: false });
    let editModalClose = () => this.setState({ editModalShow: false });
    let deleteModalClose = () => this.setState({ deleteModalShow: false });
    return (
      <div>
        <Table className="mt-4" striped bordered hover size="sm">
          <thead>
            <tr>
              <th>Medication Plan ID</th>
              <th>Name</th>
              <th>Medication</th>
              <th>Assigned By</th>
              <th>Options</th>
              <th>Delete</th>
            </tr>
          </thead>
          <tbody>
            {Plans.map(medication_plan => (
              <tr key={medication_plan.id}>
                <td>{medication_plan.id}</td>
                <td>{medication_plan.name}</td>
                <td>{medication_plan.medication}</td>
                <td>{medication_plan.assigned_by}</td>
                <td>
                  <ButtonToolbar>
                    <Button
                      className="mr-2"
                      variant="info"
                      onClick={() =>
                        this.setState({
                          editModalShow: true,
                          id: medication_plan.id,
                          name: medication_plan.name,
                          medication: medication_plan.medication,
                          assigned_by: medication_plan.assigned_by
                        })
                      }
                    >
                      Edit
                    </Button>
                    <UpdateMedicationPlan
                      show={this.state.editModalShow}
                      onHide={editModalClose}
                      id={id}
                      name={name}
                      medication={medication}
                      assigned_by={assigned_by}
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
                    <DeleteMedicationPlan
                      show={this.state.deleteModalShow}
                      onHide={deleteModalClose}
                      id={medication_plan.id}
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
            Add MedicationPlan
          </Button>
          <AddMedicationPlan
            show={this.state.addModalShow}
            onHide={addModalClose}
          />
        </ButtonToolbar>
      </div>
    );
  }
}

export default MedicationPlanPage;
