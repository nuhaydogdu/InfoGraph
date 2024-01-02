import React from "react";
import "../App.css";
import { Container, Row, Col } from "react-bootstrap";
import LinkedInIcon from "@mui/icons-material/LinkedIn";
import GitHubIcon from '@mui/icons-material/GitHub';

function Footer() {
  const programmers = [
    {
      name: "Canberk Akar",
      url: "https://www.linkedin.com/in/canberk-akar-3b53a31b8/overlay/contact-info/",
    },
    {
      name: "Umut Türk",
      url: "https://www.linkedin.com/in/umutrk/",
    },
    {
      name: "Ali Mert Yılmaz",
      url: "https://www.linkedin.com/in/ali-mert/",
    },
    {
      name: "Sümer Can Ertuğral",
      url: "https://www.linkedin.com/in/sumercanertugral/",
    },
    {
      name: "Eyyup Çoker",
      url: "https://www.linkedin.com/in/eyyup-%C3%A7oker-bb5180237/",
    },
    {
      name: "Nuh Aydoğdu",
      url: "https://www.linkedin.com/in/nuh-aydd/",
    },
    {
      name: "Eray Ağarer",
      url: "https://www.linkedin.com/in/eray-a%C4%9Farer/",
    },
  ];

  const programmers_github = [
    {
      name: "Canberk Akar",
      url: "https://github.com/CanberkAkar",
    },
    {
      name: "Umut Türk",
      url: "https://github.com/umuttrk",
    },
    {
      name: "Ali Mert Yılmaz",
      url: "https://github.com/alimert1",
    },
    {
      name: "Sümer Can Ertuğral",
      url: "https://github.com/sumercanertugral",
    },
    {
      name: "Eyyup Çoker",
      url: "https://github.com/eyyupcoker",
    },
    {
      name: "Nuh Aydoğdu",
      url: "https://github.com/nuhaydogdu",
    },
    {
      name: "Eray Ağarer",
      url: "https://github.com/eagarer",
    },
  ];

  return (
    <Container className="custom-container mb-3 p-3">
      <Row>
        <Col>
          <ul>
            {programmers.map((item) => (
               <li>
               <LinkedInIcon color="primary" />
               <a className="programmers"
                 target="_blank"
                 rel="noreferrer"
                 href={item.url}
               >
                 {item.name}
               </a>
             </li>
            ))}
          </ul>
        </Col>
        <Col>
        <ul>
            {programmers_github.map((item) => (
               <li>
               <GitHubIcon color="primary" />
               <a className="programmers"
                 target="_blank"
                 rel="noreferrer"
                 href={item.url}
               >
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
