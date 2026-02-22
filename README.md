# AI Document Analyzer API

A production-ready ASP.NET Core Web API that accepts PDF uploads, extracts text, sends it to Azure OpenAI, and returns structured analysis including summary, key points, and action items.

## Features

- **PDF Text Extraction** — Upload any text-based PDF for analysis
- **AI-Powered Analysis** — Leverages Azure OpenAI to generate summaries, key points, and action items
- **Structured JSON Output** — Clean, typed response with document metadata
- **Input Validation** — File type, size limits, and empty-document detection
- **Observability** — Structured logging with correlation IDs, processing time tracking
- **Resilience** — Retry policies and timeouts for external service calls

## Tech Stack

- .NET 10 / ASP.NET Core Web API
- Azure OpenAI (GPT-4o)
- PdfPig (PDF text extraction)
- Docker support

## Getting Started

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- An Azure OpenAI resource with a deployed model

### Configuration

Set your Azure OpenAI credentials using user secrets (never commit API keys):

```bash
cd AiDocumentAnalyzer
dotnet user-secrets init
dotnet user-secrets set "AzureOpenAi:Endpoint" "https://your-resource.openai.azure.com/"
dotnet user-secrets set "AzureOpenAi:ApiKey" "your-api-key"
dotnet user-secrets set "AzureOpenAi:DeploymentName" "gpt-4o"
```

### Run locally

```bash
cd AiDocumentAnalyzer
dotnet run
```

The API will be available at `http://localhost:5121`.

### API Endpoints

#### Health Check

```bash
curl http://localhost:5121/api/health
```

#### Analyze Document

```bash
curl -X POST http://localhost:5121/api/documents/analyze \
  -F "file=@document.pdf"
```

**Response:**

```json
{
  "summary": "...",
  "keyPoints": ["..."],
  "actionItems": ["..."],
  "metadata": {
    "pages": 3,
    "characters": 4521,
    "processingTimeMs": 1234
  }
}
```

## Project Structure

```
AiDocumentAnalyzer/
├── Controllers/         # API endpoints
├── Models/              # DTOs and response models
├── Services/            # Business logic (PDF extraction, AI analysis)
├── Configuration/       # Strongly-typed options classes
└── Program.cs           # Application entry point and DI setup
```

## License

MIT
