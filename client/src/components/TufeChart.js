import React from "react";
import { Container, Row, Col } from "react-bootstrap";
import Accordion from "react-bootstrap/Accordion";
import Chart from "react-apexcharts";
import { resdata } from "../resData/resdataTufe";

function Graphics() {
  console.log(resdata);
  const groupedData = {};

  resdata.forEach((item) => {
    const year = item.year;

    // Eğer obje içinde bu yıl yoksa, bir dizi oluştur
    if (!groupedData[year]) {
      groupedData[year] = [];
    }

    // Veriyi ilgili yılın dizisine ekle
    groupedData[year].push(item);
  });

  Object.keys(groupedData).forEach((year) => {
    groupedData[year].data = {
      options: {
        chart: {
          id: `basic-bar-${year}`,
        },
        dataLabels: {
          enabled: false,
        },
        xaxis: {
          categories: groupedData[year].map((item) => item["group"]),
        },
      },
      series: [
        {
          name: "percentage",
          data: groupedData[year].map((item) => item["percentage"]),
        },
      ],
    };
  });

  console.log(groupedData);

  return (
    <Container>
      <Row>
        <Col>
          <Accordion defaultActiveKey={["0"]} alwaysOpen>
            {Object.keys(groupedData).map((year, index) => (
              <Accordion.Item eventKey={index}>
                <Accordion.Header>{year}</Accordion.Header>
                <Accordion.Body>
                  <Chart
                    options={groupedData[year].data.options}
                    series={groupedData[year].data.series}
                    type="bar"
                    width="500"
                  />
                </Accordion.Body>
              </Accordion.Item>
            ))}
          </Accordion>
        </Col>
      </Row>
    </Container>
  );
}

export default Graphics;
