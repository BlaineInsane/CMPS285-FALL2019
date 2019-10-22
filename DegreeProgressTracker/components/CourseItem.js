import React from 'react';
import { StyleSheet, Text, View, Button, TouchableOpacity, TextInput } from 'react-native';

const CourseItem = props => {

    return (

        <TouchableOpacity onPress={props.nav}>
            <View style={styles.container}>
                <Text style={styles.text}>{props.title}</Text>
            </View>
        </TouchableOpacity>

    );
};

const styles = StyleSheet.create({

    container: {
        alignSelf: 'center',
        height: 40,
        width: '100%',
        backgroundColor: 'grey',
        paddingLeft: 5,
        justifyContent: 'center',
        shadowColor: "#000",
        shadowOffset: {
            width: 0,
            height: 5,
        },
        shadowOpacity: 0.34,
        shadowRadius: 6.27,
        elevation: 10,
    },
    text: {
        color: 'white',
        fontWeight: 'bold',
        textTransform: 'uppercase'
    },

});

export default CourseItem;