# How to Contribute
1. Ask to be invited by providing your email associated with github
1. Accept invitation that is in your email.
1. Go to https://github.com/DmitryLandy/Hunt-The-Wumpus
1. Click green button named "Code"
1. Copy URL
1. Open Command Prompt
1. Navigate to where you want the repository to reside on local machine.
1. Type "git clone https://github.com/DmitryLandy/Hunt-The-Wumpus.git"
	> **Repository should start downloading to your machine**
1. Type "cd" into Hunt-The-Wumpus directory.
1. Type "git checkout -b xxxxxx" where xxxxxx is what you want to call this branch.
1. Verify that you are working on new branch by typing "git branch".  It should show an asteric(\*) next to the name of the branch you are currently working in.
1. Make changes to the files.
1. Stage files by typing "git add XXXX" where xxxx is file names or "."for all files.
1. Commit files by typing "git commit -m "xxxxx"" where xxxx inside double quotes is the message.
1. Push to remote by typing "git push origin XXXXX" where XXXXX is the name of the branch you are on and orgin is the URL for the repository.  If you didn't set up the URL you can just copy the repository URL from step 8 and replace as such:
	> "git push https://github.com/DmitryLandy/Hunt-The-Wumpus testbranch".  testbranch is the name of the branch you want to add to or create if it doesn't exist.
1. Login once prompted
	> **Updates should start uploading to a new branch.
1. Go to Github and Click "Compare & pull request"".  
1. Add a descripiton of the added features and click "Pull Request".
1. Assign reviewers by clicking "Reviewers" to the right near the top.
1. Once reviewed by team, the team lead will merge the pull request.




