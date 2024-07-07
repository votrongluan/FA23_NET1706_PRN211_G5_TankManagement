## Collaborate with Your Team

To collaborate within the team without forking, follow these steps:

### Branching Strategy

We use a Git branching strategy with three main branches:

- `main`: Contains the stable version of the code. Direct commits to this branch are restricted.
- `dev`: Contains the latest development changes. This is the main branch for ongoing development.
- `test`: Contains code that is under testing before being merged into `dev`.

### Working on a Feature

1. Create a new branch from `dev` for your feature:

   ```bash
   git checkout dev
   git pull origin dev
   git checkout -b feature/your-feature-name
   ```

2. Make your changes and commit them:

   ```bash
   git add .
   git commit -m 'Add some feature'
   ```

3. Push your branch to the repository:

   ```bash
   git push origin feature/your-feature-name
   ```

4. Create a pull request (PR) from your feature branch to `test` for testing:

   - Ensure all tests pass before requesting a merge.
   - Team members review and approve the PR.
   - Once approved, the PR is merged into `test`.

5. After thorough testing, create a pull request from `test` to `dev`.

6. For releases, create a pull request from `dev` to `main`.

### Inviting Collaborators

- Go to your repository on GitHub.
- Click on `Settings`.
- Select `Manage Access`.
- Click `Invite a collaborator` and add the GitHub usernames of your team members.
