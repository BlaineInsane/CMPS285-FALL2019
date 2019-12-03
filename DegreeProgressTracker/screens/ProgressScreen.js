import React from 'react';
import { StyleSheet, Text, View, Button, TouchableOpacity, TextInput, ImageBackground } from 'react-native';
import { ProgressBar, Colors } from 'react-native-paper';

const ProgressScreen = props => {

    return (

        <ImageBackground
            style={{
                flex: 1,
                position: 'absolute',
                width: '100%',
                height: '100%',
                justifyContent: 'center',
            }}
            source={require('../assets/Background.png')}
        >

            <View style={styles.container}>

                <View>

                    <Text style={styles.title}>Your Progress</Text>

                </View>

                <View style={styles.progressContainer}>

                    <Text style={styles.progressTitle}>Computer Science Scientific: 87.5%</Text>
                    <ProgressBar style={{ width: '100%'}} progress={0.5} color={Colors.white} />

                </View>


            </View>

        </ImageBackground>

    );

};

const styles = StyleSheet.create({

    container: {
        height: '100%',
        width: '100%',
        //backgroundColor: '#1E8449',
        justifyContent: 'space-between',

    },
    title: {
        fontSize: 35,
        textAlign: "center",
        color: 'white',
        paddingTop: 100,
        //fontFamily: 'Helvetica',
    },
    progressContainer: {
        paddingBottom: 300,
        paddingHorizontal: '10%',
        width: '100%',
        
    },
    progressTitle: {
        textAlign: 'left',
        color: 'white',
        fontSize: 18,
    },
    button: {
        width: '80%',
        paddingBottom: 15,
    }
});

export default ProgressScreen;