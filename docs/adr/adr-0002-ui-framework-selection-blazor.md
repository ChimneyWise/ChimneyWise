---
title: "ADR-0002: UI Framework Selection - Blazor vs WPF vs WinUI 3"
status: "Accepted"
date: "2026-05-16"
authors: "Jens Tirsvad Nielsen (Approver)"
tags: ["architecture", "decision"]
supersedes: ""
superseded_by: ""
---

# ADR-0002: UI Framework Selection - Blazor vs WPF vs WinUI 3

## Status

**Accepted**

## Context

The project requires a modern, maintainable, and flexible UI framework for chimney design and construction. The team must select a UI technology that supports cross-platform deployment, web and desktop scenarios, and aligns with Clean Architecture and cloud-readiness goals. The UI should be easy to maintain, support rapid development, and integrate well with .NET and containerization workflows.

## Decision

We will use **Blazor** as the primary UI framework for the project. Blazor enables building interactive web UIs using C# and .NET, supports both server-side and WebAssembly hosting models, and aligns with our cloud and containerization strategy. It allows for code sharing between client and server, and offers a modern development experience with strong tooling support.

## Consequences

### Positive

- **ADR-0002-POS-001**: Enables cross-platform and web-based deployment, increasing accessibility
- **ADR-0002-POS-002**: Facilitates cloud-readiness and containerization (Docker, Azure, AWS)
- **ADR-0002-POS-003**: Allows code sharing between UI and backend logic in C#
- **ADR-0002-POS-004**: Modern development experience with strong .NET tooling and ecosystem

### Negative

- **ADR-0002-NEG-001**: Desktop-native features (e.g., advanced hardware integration) may require additional work or interop
- **ADR-0002-NEG-002**: Potential performance limitations compared to native desktop frameworks for some scenarios
- **ADR-0002-NEG-003**: Requires web server for Blazor Server or WebAssembly hosting for Blazor WASM

## Alternatives Considered

### WPF

- **ADR-0002-ALT-001**: **Description**: Use Windows Presentation Foundation (WPF) for a traditional Windows desktop application
- **ADR-0002-ALT-002**: **Rejection Reason**: Windows-only, limited cross-platform support, less alignment with cloud/container goals, and less modern web integration

### WinUI 3

- **ADR-0002-ALT-003**: **Description**: Use WinUI 3 for a modern Windows desktop application
- **ADR-0002-ALT-004**: **Rejection Reason**: Windows-only, less mature ecosystem, limited cross-platform and web support, and less alignment with Clean Architecture and cloud-readiness

## Implementation Notes

- **ADR-0002-IMP-001**: Use Blazor (Server or WASM) for UI development
- **ADR-0002-IMP-002**: Integrate with .NET backend and follow Clean Architecture principles
- **ADR-0002-IMP-003**: Containerize application using Docker for local and cloud deployment
- **ADR-0002-IMP-004**: Monitor for any advanced desktop integration needs and address via interop or hybrid approaches if required

## References

- **ADR-0002-REF-001**: [Blazor Documentation](https://learn.microsoft.com/en-us/aspnet/core/blazor/)
- **ADR-0002-REF-002**: [Blazor vs WPF vs WinUI 3](https://devblogs.microsoft.com/dotnet/introducing-blazor/)
- **ADR-0002-REF-003**: [Clean Architecture](https://8thlight.com/blog/uncle-bob/2012/08/13/the-clean-architecture.html)
