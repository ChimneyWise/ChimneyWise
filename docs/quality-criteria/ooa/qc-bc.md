# 🧑‍💻 Quality Criteria: Business Case (BC)
The Business Case (BC) is a structured document that justifies the initiation of a project or task. It outlines the rationale, expected benefits, costs, risks, and alternatives, providing a basis for decision-making and prioritization.

## Metadata
| Key               | Value                             |
|-------------------|-----------------------------------|
| Id                | QC-BC                             |
| crossReference    | Applying UML and patterns by Craig Larman |

### Change Log
| Date       | Version | Description                     | Author        |
|------------|---------|---------------------------------|---------------|
| 2026-03-29 | 0001    | Initial creation                | Tirsvad       |
| 2026-05-16 | 0002    | Updated template and add missing sections | Tirsvad |

## Quality Criteria:
When evaluating a Business Case, consider the following quality criteria:
1. **Clarity and Structure**: The BC should be well-organized, with clear sections and concise language. Avoid jargon and ensure the rationale is easy to follow.
1. **Completeness**: Ensure that all essential components are addressed:
   - Executive Summary
   - Problem Statement
   - Objectives
   - Options and Alternatives (0-scenario, 1-scenario, 2-scenario)
   - Cost Benefit Analysis
   - Risks and Mitigations
   - Timeline
   - Success Criteria

1. **Relevance**: The information provided should be specific to the project or task. Avoid generic statements that do not add value.
1. **Consistency**: The components of the BC should logically support each other. For example, the objectives should align with the benefits and success criteria.
1. **Evidence-Based**: Claims and projections should be supported by data, references, or reasonable assumptions.

## Authoring Patterns and Templates
- For filename conventions, templates, and authoring examples, see `.github/instructions/businesscase.instructions.md`.

## Validation
- Review the BC for completeness, clarity, and correct use of the template.
- Verify that all placeholders are replaced with project-specific content.
- Ensure that the BC is reviewed and approved by relevant stakeholders (e.g., product owner, business analyst).

## Maintenance
- Update the version and change log for major changes.
- Regularly review and update the BC as project assumptions, costs, benefits, or risks evolve.

## Language/Translation Compliance
- If the product owner’s language is not English, ensure that the BC is translated and compliant with dual-file requirements. Create a separate file for the translated content while maintaining English for metadata and versioning.

## File Naming
- Name files and folders without spaces, using digits for versioning, following the pattern: `bc.md` (e.g., `bc.md` or for a translated version, `bc.<language>.md`).
