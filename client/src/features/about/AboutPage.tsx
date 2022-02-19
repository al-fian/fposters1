import { Container, Typography } from "@mui/material";
import { useState } from "react";
import agent from "../../app/api/agent";

export default function AboutPage() {
    const [validationErrors, setValidationErrors] = useState<string[]>([]);

    function getValidationError() {
        agent.TestErrors.getValidationError()
            .then(() => console.log('should not see this'))
            .catch(error => setValidationErrors(error));
    }

    return (
        <Container>
            <Typography gutterBottom variant='body1'>This is an e-commerce website for a demo. Developed not for its design but for its functionalities.</Typography>
            <Typography gutterBottom variant='h6'>Technologies used:</Typography>
            <Typography gutterBottom variant='h6'>Backend</Typography>
            <ul>
                <li>ASPNET Core 6</li>
                <li>C#</li>
                <li>PostGreSQL</li>
                <li>Restful Web API</li>
            </ul>
            <Typography gutterBottom variant='h6'>Frontend</Typography>
            <ul>
                <li>ReactJS</li>
                <li>Redux</li>
                <li>Typescript</li>
            </ul>
            <Typography gutterBottom variant='h6'>Payment Method</Typography>
            <ul>
                <li>Stripe</li>
            </ul>
        </Container>
    )
}