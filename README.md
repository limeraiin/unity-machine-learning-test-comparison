# Continuous Vs. Discrete Actions in AI Behaviour 
In this machine learning experiment, I have analyzed the effect of using floating point numbers instead of integers in AI actions. 

## About the Experiment

I have created a very basic machine learning scenario. The AI has to prevent colliding with obstacles and the ceiling. It gets a little reward for each successful dodging and a big punishment for every colliding.  

Used tools: Pytorch, ML Agents (1.1.0-preview 3), Tensorboard, Unity3D.

### Test field:
<p align="center">
   <img src="https://user-images.githubusercontent.com/64265868/118036872-c9049b80-b375-11eb-8db3-eeefac0763c0.png" alt="drawing" width="1000"/>
</p>

8 different playgrounds are used to speed up the learning process. Children of each agent has a vertically attached "Ray Perception Sensor" component. There have been no observations other than that.

There are rewarding walls that agents have to collide into behind every obstacle.  
(Obsticles are randomly spawned)

## Results

Both tests ran for one million steps. Blue and orange lines represent the mean reward for float and integer actions of the AI respectively.  
(Each reward has a value of 0.1f, punishments have -1f)

<p align="center">
<img src="https://user-images.githubusercontent.com/64265868/118035386-d15bd700-b373-11eb-8858-84aa18f43515.jpg" alt="drawing" width="600"/>
</p>

It was pretty hard to control the jumps even while the agent was in human control. As can be seen above, using float data type for AI actions shortened the learning period dramatically. After around 800k steps, test runs started to complete with little to no mistakes but they didn't contribute to the mean reward graph.

The mean loss of the value update correlates to how well the model is able to predict the value of each state. This should increase while the agent is learning, and then decrease once the reward stabilizes.

<p align="center">
<img src="https://user-images.githubusercontent.com/64265868/118036278-0d436c00-b375-11eb-912f-2cb735ba0e4b.jpg" alt="drawing" width="600"/>
</p>

## Working Example

Running a test using the brain of the AI with float type actions after 1 million learning step:


![test3](https://user-images.githubusercontent.com/64265868/118038183-79bf6a80-b377-11eb-8160-1a21d6620db8.gif)



![test4](https://user-images.githubusercontent.com/64265868/118038201-7e841e80-b377-11eb-891f-1700da1c8079.gif)

