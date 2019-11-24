import React, { Component } from 'react';
import { View, Image, Text, Button, StyleSheet } from 'react-native';
import Modal from 'react-native-modal';

export default class ClassModal extends Component {
    state = {
        isModalVisible: false
    };
  
    toggleModal = () => {
        this.setState({ isModalVisible: !this.state.isModalVisible });
    };
  
    render() {
        return (
            <View>
                <Button title="Show modal" onPress={this.toggleModal} />
                    <Modal 
                        backdropOpacity = {0.70}
                        isVisible={this.state.isModalVisible}
                        onBackdropPress={() => this.setState({ isModalVisible: false })}
                        onBackButtonPress={() => this.setState({ isModalVisible: false })}
                    >
                        <View style = {styles.modalContainer}>
                            <Text>WE IN THE MODAL</Text>
                        </View>
                    </Modal>
            </View>
      );
    }
}

const styles = StyleSheet.create({
    
    modalContainer: {
        borderRadius: 5,
        backgroundColor: 'gray',
        height: '65%',
        width: '90%',
        alignSelf: 'center'
    }
})

{/*
const ClassModal = props => (
    <Modal style={styles.modalContainer}
        isVisible ={true}
        backdropColor = {'white'}
    >
        <View>
            <Text>IN THE MODAL BABY</Text>
        </View>
    </Modal>
);

state = {
    isModalVisible: false
};

const toggleModal = () => {
    this.setState({ isModalVisible: !this.StaticRange.isModalVisible });
}

const styles = StyleSheet.create({
    
    modalContainer: {
        height: '80%',
        width: '80%',
        flex: 1,
    }
})

export default ClassModal;
*/}