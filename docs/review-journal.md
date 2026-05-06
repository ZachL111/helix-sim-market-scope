# Review Journal

The review surface for `helix-sim-market-scope` is deliberately narrow: one fixture, one scoring rule, and one local check.

The local checks classify each case as `ship`, `watch`, or `hold`. That gives the project a small review vocabulary that matches its simulations focus without claiming live deployment or external usage.

## Cases

- `baseline`: `input pressure`, score 194, lane `ship`
- `stress`: `state drift`, score 197, lane `ship`
- `edge`: `review cost`, score 179, lane `ship`
- `recovery`: `decision risk`, score 185, lane `ship`
- `stale`: `input pressure`, score 201, lane `ship`

## Note

A future change should add new cases before it changes the scoring rule.
