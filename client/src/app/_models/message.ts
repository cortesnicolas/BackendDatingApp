export interface Message {
  id: number;
  senderId: number;
  senderUsername: string;
  senderPhotoUrl: string;
  recipientId: number;
  recipientUsername: string;
  recipientPhotoUrl: string;
  recipient: string;
  content: string;
  dateRead?: Date;
  messageSent: Date;
}
