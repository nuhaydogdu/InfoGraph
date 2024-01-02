import React from "react";
import { Routes, Route, useLocation } from "react-router-dom";
import { Container, Row, Col } from "react-bootstrap";
import HappinessChart from "./HappinessChart";
import ForeignTradeChart from "./ForeignTradeChart";
import TufeChart from "./TufeChart";
import Project from "./Project";

function Content({resdata}) {
  const location = useLocation();
  console.log("location --> ", location);

  const queries = [
    { path: "/", content: "Anasayfa" },
    { path: "/hapinness", content: "Yıllara ve Yaşa Göre Mutluluk Oranı" },
    { path: "/foregin", content: "İhracat Endeksi Sayfası" },
    { path: "/tufe", content: "TÜFE Sayfası" },
  ];
  return (
    <Container className="custom-container p-3 h-100">
      <Row>
        <Col>
          {queries.map(
            (query) =>
              location.pathname === query.path && (
                <React.Fragment key={query.path}>
                  <h3
                    className="d-flex align-items-center justify-content-center"
                    style={{ color: "#008fcf" }}
                  >
                    {query.content}
                  </h3>
                </React.Fragment>
              )
          )}

          <hr className="hrStyleTwo" />
        </Col>
      </Row>
      <Row>
        <Col>
          <Routes>
            <Route path="/" element={<Project />} />
            <Route path="/hapinness" element={<HappinessChart resdata={resdata}/>} />
            <Route path="/foregin" element={<ForeignTradeChart resdata={resdata}/>} />
            <Route path="/tufe" element={<TufeChart resdata={resdata}/>} />
          </Routes>
        </Col>
      </Row>
    </Container>
  );
}

export default Content;
