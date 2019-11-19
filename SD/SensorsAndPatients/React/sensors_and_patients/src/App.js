import React from "react";
import "./App.css";
import NavigationBar from "./components/navigationBar";
import { BrowserRouter, Route, Switch } from "react-router-dom";
import "bootstrap/dist/css/bootstrap.min.css";
import ActivitiesPage from "./components/activitiesPage";
import NotificationPage from "./components/notificationsPage";
import Home from "./components/home";

function App() {
  return (
    <BrowserRouter>
      <div className="containter">
        <NavigationBar />
        <Switch>
          <Route path="/" component={Home} exact />
          <Route path="/activities" component={ActivitiesPage} />
          <Route path="/notifications" component={NotificationPage} />
        </Switch>
      </div>
    </BrowserRouter>
  );
}

export default App;
