import { useState } from "react";
import "../App.css";
import { Container, Row, Col } from "react-bootstrap";
import LinkedInIcon from "@mui/icons-material/LinkedIn";

function Footer() {
  const likedin = [
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
  return (
    <Container className="custom-container mb-3 p-3">
      <Row>
        <Col>
          <ul>
            {likedin.map((item) => (
               <li>
               <LinkedInIcon color="primary" />
               <a
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
        <Col>gitHub linkleri</Col>
      </Row>
    </Container>
  );
}

export default Footer;
