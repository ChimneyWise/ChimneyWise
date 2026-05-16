---
description: ' Business Case (BC) quality requirements and template for project documentation.'
applyTo: '/docs/bc.md' and '/docs/bc.*.md'
reference: 'docs/quality-criteria/ooa/qc-bc.md'
---

# BC Instructions (Summary)
- Use the provided BC markdown template / examples.
- Replace all placeholders with project-specific content.
- Store BC files in `docs/` as `bc.md`.
- Increment version numbers for significant changes and add it to the change log.
- Include metadata, Change log (with date, author).
- Create files in English; if product owner domain language differs, create a separate file with language
- Use the provided BC markdown template / examples.

## BC Template (Minimal):
```markdown
# Business Case (BC) for [Insert Project Name]
## Metadata
| Key               | Value                             |
|-------------------|-----------------------------------|
| Id                | BC                                |
| crossReference    | [Insert Reference to DM or other relevant document] |

## Change log
| Version | Date       | Author         | Description                        |
|---------|------------|----------------|------------------------------------|
| 0001    | [insert date of now in format yyyy-mm-dd] | Initial                  | [Insert Author Name] |

## Executive Summary
[Insert a brief summary of the business case, including the problem statement, proposed solution, and expected benefits.]

## Problem Statement
[Insert problem statement describing the issue or opportunity that the project aims to address.]

## Proposed Solution
[Insert a description of the proposed solution, including key features and how it addresses the problem statement.]

## Objectives

## Options and Alternatives (0-scenario, 1-scenario, 2-scenario)
- **0-scenario**: [Insert description of the 0-scenario, which represents the status quo or no action taken.]
- **1-scenario**: [Insert description of the 1-scenario, which represents the proposed solution being implemented.]
- **2-scenario**: [Insert description of the 2-scenario, which represents an alternative solution or approach being implemented.]

## Cost-Benefit Analysis
### Costs
- **Development Costs**: [Insert description of the costs associated with developing the proposed solution.]
- **Training Costs**: [Insert description of the costs associated with training users on the proposed solution.]
- **Maintenance Costs**: [Insert description of the costs associated with maintaining the proposed solution
- **Implementation Costs**: [Insert description of the costs associated with implementing the proposed solution.]
- **Opportunity Costs**: [Insert description of the costs associated with the opportunity cost of implementing the proposed solution.]

### Benefits
- **Increased Efficiency**: [Insert description of how the proposed solution will increase efficiency and save time.]
- **Cost Savings**: [Insert description of how the proposed solution will reduce costs.]
- **Enhanced Communication**: [Insert description of how the proposed solution will improve communication among stakeholders.]
- **Improved Project Management**: [Insert description of how the proposed solution will improve project management and quality control.]

## Risks and Mitigations
see docs/risk-and-mitigation.md

## Timeline
see milestone-gateways.md

## Success Criteria
- [Insert success criterion 1]
- [Insert success criterion 2]

```
