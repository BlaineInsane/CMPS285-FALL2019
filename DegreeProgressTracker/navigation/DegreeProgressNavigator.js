import { createStackNavigator } from 'react-navigation-stack';
import { createAppContainer } from 'react-navigation';

import WelcomeScreen from '../screens/WelcomeScreen';
import SignUpScreen from '../screens/SignUpScreen';
import LogInScreen from '../screens/LogInScreen';

const DegreeProgressNavigator = createStackNavigator({
    Welcome: WelcomeScreen,
    LogIn: LogInScreen,
    SignUp: SignUpScreen,
});

export default createAppContainer(DegreeProgressNavigator);