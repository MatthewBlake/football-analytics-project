# ADR 001: Incremental Architecture

## Status

Accepted

## Context

The long-term goal of this project is to build a production-style football analytics platform incorporating modern backend technologies including PostgreSQL, Kafka, Redis, Kubernetes and Azure.

Introducing all of these technologies at the beginning would significantly increase complexity and make it more difficult to understand the impact of each architectural decision.

## Decision

The project will be developed incrementally.

The platform will begin as a single ASP.NET Core Web API using in-memory data.

Additional technologies and services will be introduced in small, well-defined phases.

## Consequences

### Positive

- Easier to understand each architectural decision.
- Simpler debugging.
- Smaller pull requests.
- Continuous delivery of working software.
- Clear project history showing architectural evolution.

### Negative

- Some implementation work will be refactored as new technologies are introduced.
- Additional effort is required to maintain documentation throughout the project.