# helix-sim-market-scope

`helix-sim-market-scope` explores simulations with a small C# codebase and local fixtures. The technical goal is to create a C# reference implementation for market workflows, centered on state machine modeling, transition tables, and invalid-transition tests.

## Problem It Tries To Make Smaller

This is intentionally local and self-contained so it can be inspected without credentials, services, or seeded history.

## Helix Sim Market Scope Review Notes

The first comparison I would make is `input pressure` against `review cost` because it shows where the rule is most opinionated.

## Working Pieces

- `fixtures/domain_review.csv` adds cases for input pressure and state drift.
- `metadata/domain-review.json` records the same cases in structured form.
- `config/review-profile.json` captures the read order and the two review questions.
- `examples/helix-sim-market-walkthrough.md` walks through the case spread.
- The C# code includes a review path for `input pressure` and `review cost`.
- `docs/field-notes.md` explains the strongest and weakest cases.

## Design Notes

The repository has two validation layers: the original compact policy fixture and the domain review fixture. They are separate so one can change without hiding failures in the other.

The C# code keeps the review rule close to the tests.

## Example Run

```powershell
powershell -NoProfile -ExecutionPolicy Bypass -File scripts/verify.ps1
```

## Tests

The check exercises the source code and the review fixture. `stale` is the high score at 201; `edge` is the low score at 179.

## Known Limits

The repository is intentionally scoped to local checks. I would expand it by adding adversarial fixtures before adding features.
