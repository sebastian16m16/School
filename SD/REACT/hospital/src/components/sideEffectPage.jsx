import React, { Component } from "react";
import { Table, Button, ButtonToolbar } from "react-bootstrap";
import UpdateSideEffect from "./SideEffect/updateSideEffect";
import AddSideEffect from "./SideEffect/addSideEffect";
import DeleteSideEffect from "./SideEffect/deleteSideEffect";

class SideEffectPage extends Component {
  constructor(props) {
    super(props);
    this.state = {
      SideEffects: [],
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
    fetch("https://localhost:44379/api/sideeffect")
      .then(res => res.json())
      .then(data => {
        this.setState({ SideEffects: data });
      });
  }
  render() {
    const { SideEffects, id, detail } = this.state;

    let addModalClose = () => this.setState({ addModalShow: false });
    let editModalClose = () => this.setState({ editModalShow: false });
    let deleteModalClose = () => this.setState({ deleteModalShow: false });
    return (
      <div>
        <Table className="mt-4" striped bordered hover size="sm">
          <thead>
            <tr>
              <th>SideEffect ID</th>
              <th>Details</th>
              <th>Options</th>
              <th>Delete</th>
            </tr>
          </thead>
          <tbody>
            {SideEffects.map(side_effect => (
              <tr key={side_effect.id}>
                <td>{side_effect.id}</td>
                <td>{side_effect.detail}</td>
                <td>
                  <ButtonToolbar>
                    <Button
                      className="mr-2"
                      variant="info"
                      onClick={() =>
                        this.setState({
                          editModalShow: true,
                          id: side_effect.id,
                          detail: side_effect.detail
                        })
                      }
                    >
                      Edit
                    </Button>
                    <UpdateSideEffect
                      show={this.state.editModalShow}
                      onHide={editModalClose}
                      id={id}
                      detail={detail}
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
                    <DeleteSideEffect
                      show={this.state.deleteModalShow}
                      onHide={deleteModalClose}
                      id={side_effect.id}
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
            Add SideEffect
          </Button>
          <AddSideEffect
            show={this.state.addModalShow}
            onHide={addModalClose}
          />
        </ButtonToolbar>
      </div>
    );
  }
}

export default SideEffectPage;
