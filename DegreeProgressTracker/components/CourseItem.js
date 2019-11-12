import React from 'react';
import { StyleSheet, Text, View, Button, TouchableOpacity, TextInput } from 'react-native';
import { MaterialCommunityIcons } from '@expo/vector-icons';

const CourseItem = props => {

    return (

        <TouchableOpacity onPress={props.nav}>
            <View style={styles.container}>
                <View paddingTop={15}><Text style={styles.text}>{props.title}</Text></View>
                <View><MaterialCommunityIcons name="plus-box-outline" size={32} color="white"/></View>
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
        justifyContent: 'space-between',
        shadowColor: "#000",
        shadowOffset: {
            width: 0,
            height: 5,
        },
        shadowOpacity: 0.34,
        shadowRadius: 6.27,
        elevation: 10,
        flexDirection: "row",
    },
    text: {
        color: 'white',
        fontWeight: 'bold',
        textTransform: 'uppercase'
    },

});

export default CourseItem;