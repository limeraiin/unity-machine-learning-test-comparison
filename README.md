# Continuous Vs. Discrete Actions in Ai Behaviour 
In this machine learning experiment, I have analyzed the effect of using floating point numbers instead of integers in AI actions. 

## About the Experiment

I have created a very basic machine learning scenario. The AI has to prevent colliding with obstacles and the ceilingç. It gets a little reward For each successful dodging and a big punishment for every colliding.

### Test field:
![Test field](https://user-images.githubusercontent.com/64265868/118034040-331b4180-b372-11eb-83f8-162785d92a9e.png)

8 different playgrounds are used to speed up the learning process. Children of each agent has a vertically attached "Ray Perception Sensor" component. There have been no observations other than that.

There are rewarding walls that agents have to collide behind every obstacle. 

## Results

Both tests ran for one million steps. Blue and orange lines represent the mean reward for float and integer actions of the AI respectively.
![Environment_Cumulative Reward](https://user-images.githubusercontent.com/64265868/118035386-d15bd700-b373-11eb-8858-84aa18f43515.jpg)

It was pretty hard to control the jumps even while the agent was in human control. As can be seen above, using float data type for AI actions shortened the learning period dramatically. After around 800k steps, test runs started to complete with some to no mistakes but they didn't contribute to the mean reward graph.

The mean loss of the value update. Correlates to how well the model is able to predict the value of each state. This should increase while the agent is learning, and then decrease once the reward stabilizes.

![Losses_Value Loss](https://user-images.githubusercontent.com/64265868/118036278-0d436c00-b375-11eb-912f-2cb735ba0e4b.jpg)


The brain of the AI with float actions after 1 million step:

