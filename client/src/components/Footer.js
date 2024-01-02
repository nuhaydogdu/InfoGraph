import React from "react";
import "../App.css";
import { Container, Row, Col } from "react-bootstrap";
import LinkedInIcon from "@mui/icons-material/LinkedIn";
import GitHubIcon from "@mui/icons-material/GitHub";

function Footer() {
  const programmersData = [
    {
      name: "Canberk Akar",
      linkedinUrl: "https://www.linkedin.com/in/canberk-akar-3b53a31b8/overlay/contact-info/",
      githubUrl: "https://github.com/CanberkAkar",
    },
    {
      name: "Umut Türk",
      linkedinUrl: "https://www.linkedin.com/in/umutrk/",
      githubUrl: "https://github.com/umuttrk",
    },
    {
      name: "Ali Mert Yılmaz",
      linkedinUrl: "https://www.linkedin.com/in/ali-mert/",
      githubUrl: "https://github.com/alimert1",
    },
    {
      name: "Sümer Can Ertuğral",
      linkedinUrl: "https://www.linkedin.com/in/sumercanertugral/",
      githubUrl: "https://github.com/sumercanertugral",
    },
    {
      name: "Eyyup Çoker",
      linkedinUrl: "https://www.linkedin.com/in/eyyup-%C3%A7oker-bb5180237/",
      githubUrl: "https://github.com/eyyupcoker",
    },
    {
      name: "Nuh Aydoğdu",
      linkedinUrl: "https://www.linkedin.com/in/nuh-aydd/",
      githubUrl: "https://github.com/nuhaydogdu",
    },
    {
      name: "Eray Ağarer",
      linkedinUrl: "https://www.linkedin.com/in/eray-a%C4%9Farer/",
      githubUrl: "https://github.com/eagarer",
    },
  ];



  return (
    <Container className="custom-container mb-3 p-3">
      <Row>
        <Col className='d-flex align-items-end justify-content-end'>
          <ul className="menu-list p-3">
            {programmersData.map((item,index) => (
              <li key={index} className="ps-5">
                <LinkedInIcon style={{color:'#008fcf'}}  className="me-3"/>
                <a target="_blank" rel="noreferrer" href={item.linkedinUrl}>
                  {item.name}
                </a>
              </li>
            ))}
          </ul>
        </Col>

        <Col>
        <div className="outer">
        <div className="inner"></div>
        </div>
        
        </Col>
        <Col className='d-flex align-items-start justify-content-start'>
          <ul className="menu-list p-3">
            {programmersData.map((item, index) => (
              <li key={index} className="pe-5">
                <GitHubIcon style={{color:'#008fcf'}} className="me-3"/>
                <a target="_blank" rel="noreferrer" href={item.githubUrl}>
                  {item.name}
                </a>
              </li>
            ))}
          </ul>
        </Col>
      </Row>
    </Container>
  );
}

export default Footer;
