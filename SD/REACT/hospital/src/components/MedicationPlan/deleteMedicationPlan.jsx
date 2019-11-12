import React, { Component } from "react";
import { Modal, Button, Row, Col, Form } from "react-bootstrap";
import SnackBar from "@material-ui/core/Snackbar";
import IconButton from "@material-ui/core/IconButton";

export class DeleteCaregiver extends Component {
  constructor(props) {
    super(props);
    this.handleSubmit = this.handleSubmit.bind(this);
    this.state = { snackbaropen: false, snackbarMsg: "" };
  }

  snackbarClose = event => {
    this.setState({ snackbaropen: false });
  };

  handleSubmit(event) {
    event.preventDefault();
    console.log("ID ====>>>" + this.props.id);

    fetch("https://localhost:44379/api/medicationplan/" + this.props.id, {
      method: "Delete",
      headers: {
        Accept: "application/json",
        "Content-Type": "application/json"
      }
      //   body: JSON.stringify({
      //     id: event.target.id.value
      //   })
    })
      .then(res => res.json())
      .then(
        result => {
          this.setState({ snackbaropen: true, snackbarMsg: result });
        },
        error => {
          this.setState({
            snackbaropen: true,
            snackbarMsg: "Operation Failed"
          });
        }
      );
  }

  render() {
    return (
      <div className="container">
        <SnackBar
          anchorOrigin={{ vertical: "bottom", horizontal: "center" }}
          open={this.state.snackbaropen}
          autoHideDuration={3000}
          onClose={this.snackbarClose}
          message={<span id="message-id">{this.state.snackbarMsg}</span>}
          action={[
            <IconButton
              key="close"
              arial-label="Close"
              color="inherit"
              onClick={this.snackbarClose}
            >
              x
            </IconButton>
          ]}
        ></SnackBar>

        <Modal
          {...this.props}
          size="sm"
          aria-labelledby="contained-modal-title-vcenter"
          centered
        >
          <Modal.Header closeButton toggle={this.props.toggle}>
            <Modal.Title id="contained-modal-title-vcenter">
              Delete Alert!!!
            </Modal.Title>
          </Modal.Header>
          <Modal.Body className="d-flex justify-content-center">
            <Row>
              <Col sm={20}>
                <Form>
                  <Form.Group controlId="id">
                    <h3>Are you sure?</h3>
                  </Form.Group>
                </Form>
              </Col>
            </Row>
          </Modal.Body>
          <Modal.Footer>
            <Form className="mr-auto" onSubmit={this.handleSubmit}>
              <Button
                className="mr-auto"
                variant="danger"
                type="submit"
                onClick={this.props.onHide}
              >
                Delete
              </Button>
            </Form>
            <Button variant="primary" onClick={this.props.onHide}>
              Close
            </Button>
          </Modal.Footer>
        </Modal>
      </div>
    );
  }
}
export default DeleteCaregiver;
