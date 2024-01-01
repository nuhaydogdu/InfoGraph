import React from "react";
// import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
// import { Routes, Route, Outlet, NavLink } from "react-router-dom";
import { Routes, Route } from 'react-router-dom';
import { Container, Row, Col } from "react-bootstrap";
import HappinessChart from "./HappinessChart";
import ForeignTradeChart from "./ForeignTradeChart";
import TufeChart from "./TufeChart";
import Project from "./Project";

function Content() {

  return (
    <Container className="custom-container p-3 h-100">
      <Row>
        <Col>
          <h3 className="d-flex align-items-center justify-content-center">
            Content
          </h3>
        </Col>
      </Row>
      <Row>
        <Col>
   
            <Routes>
              <Route path="/" element={<Project />} />
              <Route path="/hapinness" element={<HappinessChart />} />
              <Route path="/foregin" element={<ForeignTradeChart />} />
              <Route path="/tufe" element={<TufeChart />} />
            </Routes>
 
          {/* <HappinessChart /> */}
          {/* <ForeignTradeChart /> */}
          {/* <TufeChart /> */}
        </Col>
      </Row>
    </Container>
  );
}

export default Content;
