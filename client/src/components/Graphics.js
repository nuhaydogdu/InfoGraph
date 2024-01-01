import React, { useEffect, useRef } from "react";
import { Container, Row, Col } from "react-bootstrap";
import Accordion from "react-bootstrap/Accordion";
import Chart from "react-apexcharts";
import { resdata } from "./resdata";

function Graphics() {

  const groupedData = {};

  resdata.forEach((item) => {
    const year = item.happinessData.year;

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
        xaxis: {
          categories: groupedData[year].map((item) => item["ratesData"]["ageInterval"]),
        },
      },
      series: [
        {
          name: "happyRate",
          data: groupedData[year].map((item) => item["ratesData"]["happyRate"]),
        },
        {
          name: "mediumRate",
          data: groupedData[year].map((item) => item["ratesData"]["mediumRate"]),
        },
        {
          name: "upsetRate",
          data: groupedData[year].map((item) => item["ratesData"]["upsetRate"]),
        },
      ],
    };
  });
  
  console.log(groupedData);

  

  // const data = {
  //   options: {
  //     chart: {
  //       id: "basic-bar",
  //     },
  //     xaxis: {
  //       categories: groupedData['2003'].map((item)=>item['ratesData']['ageInterval']),
  //     },
  //   },
  //   series: [
  //     {
  //       name: "happyRate",
  //       data: groupedData['2003'].map((item)=>item['ratesData']['happyRate']),
  //     },
  //     {
  //       name: "mediumRate",
  //       data: groupedData['2003'].map((item)=>item['ratesData']['mediumRate']),
  //     },
  //     {
  //       name: "upsetRate",
  //       data: groupedData['2003'].map((item)=>item['ratesData']['upsetRate']),
  //     },
  //   ],
  // };

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
