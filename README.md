# Carbon Foodprint Estimator API

## Overview
This project is a backend API that estimates the carbon footprint of food dishes. It was developed as a solution for the **Reewild Backend Engineer Internship Assignment**.

The API exposes two endpoints:
- `POST /estimate` → Accepts a dish name in a JSON body.
- `POST /estimate/image` → Accepts an image in multipart-form-data.

## My Approach: Solving the Azure API Challenge
My initial plan was to integrate with live AI services (Azure, Gemini). However, I encountered a critical blocker with my student Azure account, which had a policy that prevented me from creating the necessary resources.

Instead of getting stuck, I pivoted to a practical solution: a **mocked API**. This allowed me to deliver a complete, working API that perfectly matches the required data formats and endpoint structure. This approach shows my ability to:
- Identify and adapt to a critical technical roadblock.
- Still deliver a working solution on time, even when external dependencies fail.
- Think about a future, production-ready implementation, which would involve integrating with a real AI service.

## Technology Stack
- **C# / .NET (Minimal API):** A modern, high-performance framework.
- **Swagger UI:** Automatically generated documentation for easy testing.
- **Mocked Responses:** Used to demonstrate functionality without a live API key.

## Future Improvements
- **Real AI Integration:** Replace mock responses with real AI calls.
- **Data Persistence:** Integrate a database to cache previous estimates.
- **Error Handling & Security:** Implement more robust error handling and security measures.
