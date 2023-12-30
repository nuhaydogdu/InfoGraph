import React from "react";
import "../App.css"
import {Container, Row, Col} from "react-bootstrap";


function Footer() {
  return (
    <Container className="custom-container mb-3 p-3">
      <Row>
          <Col>
            <ul>
              <li>
                <a
                  target="_blank"
                  rel="noreferrer"
                  href="https://www.linkedin.com/in/canberk-akar-3b53a31b8/overlay/contact-info/"
                >
                  Canberk Akar
                </a>
              </li>
              <li>
                <a
                  target="_blank"
                  rel="noreferrer"
                  href="https://www.linkedin.com/in/umutrk/"
                >
                  Umutcan Türk
                </a>
              </li>
              <li>
                <a
                  target="_blank"
                  rel="noreferrer"
                  href="https://www.linkedin.com/in/ali-mert/"
                >
                  Ali Mert Yılmaz{" "}
                </a>
              </li>
              <li>
                <a
                  target="_blank"
                  rel="noreferrer"
                  href="https://www.linkedin.com/in/sumercanertugral/"
                >
                  Sümercan Ertuğral
                </a>
              </li>
              <li>
                <a
                  target="_blank"
                  rel="noreferrer"
                  href="https://www.linkedin.com/in/eyyup-%C3%A7oker-bb5180237/"
                >
                  Eyyup Çoker
                </a>
              </li>
              <li>
                <a
                  target="_blank"
                  rel="noreferrer"
                  href="https://www.linkedin.com/in/nuh-aydd/"
                >
                  Nuh Aydoğdu
                </a>
              </li>
              <li>
                <a
                  target="_blank"
                  rel="noreferrer"
                  href="https://www.linkedin.com/in/eray-a%C4%9Farer/"
                >
                  Eray Ağarer
                </a>
              </li>
            </ul>
          </Col>
          <Col>gitHub linkleri</Col>
      </Row>
    </Container>
  );
}

export default Footer;
