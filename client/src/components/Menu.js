import React from "react";
import { NavLink } from "react-router-dom";
import { Container, Row, Col } from "react-bootstrap";
import HomeIcon from "@mui/icons-material/Home";
import SentimentSatisfiedAltIcon from "@mui/icons-material/SentimentSatisfiedAlt";
import BusinessCenterIcon from "@mui/icons-material/BusinessCenter";
import CurrencyLiraIcon from "@mui/icons-material/CurrencyLira";
import axios from "axios";

function Menu({ setResData }) {
  const menu = [
    { name: "Anasayfa", path: "/", endpoint: "", icon: <HomeIcon /> },
    {
      name: "Mutluluk",
      path: "/hapinness",
      endpoint: "https://localhost:7235/api/HLBAG/GetAllHLBAGData",
      icon: <SentimentSatisfiedAltIcon />,
    },
    {
      name: "İhracat Endeksi",
      path: "/foregin",
      endpoint: "https://localhost:7235/api/FTVI/GetAllFTVIData",
      icon: <BusinessCenterIcon />,
    },
    {
      name: "TÜFE",
      path: "/tufe",
      endpoint: "https://localhost:7235/api/TUFE/GetAllTUFEData",
      icon: <CurrencyLiraIcon />,
    },
  ];

  async function getData(endpoint) {
    console.log("endpoint --> ", endpoint);
    setResData([]);
    await axios
      .get(endpoint)
      .then((response) => {
        // setResData("");
        setResData(response.data);
      })
      .catch((error) => console.log("getData > error --> ", error));
  }

  return (
    <Container className="custom-container h-100">
      <Row>
        <Col className="p-4">
          <h5 className="menu-baslik mb-3">
            <strong>MENÜ</strong>
          </h5>
          <hr className="hrStyleTwo" />
          {menu.map((item, index) => (
            <NavLink
              to={item.path}
              key={index}
              className="menu-link"
              onClick={async () => {
                await getData(item.endpoint);
              }}
            >
              {item.icon} {item.name}
            </NavLink>
            // <button onClick={() => getData(item.endpoint)}>{item.name}</button>
          ))}
        </Col>
      </Row>
    </Container>
  );
}

export default Menu;
