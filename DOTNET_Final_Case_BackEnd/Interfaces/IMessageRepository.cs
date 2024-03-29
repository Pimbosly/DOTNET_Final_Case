﻿using DOTNET_Final_Case_BackEnd.DTOs.MessageDTO;
using DOTNET_Final_Case_BackEnd.Models;
using Microsoft.AspNetCore.Mvc;

namespace DOTNET_Final_Case_BackEnd.Interfaces
{
    public interface IMessageRepository
    {
        /// <summary>
        /// Abstract method to get all messages.
        /// </summary>
        /// <returns>A list of messageDto.</returns>
        Task<ActionResult<IEnumerable<Message>>> GetMessagesAsync();

        /// <summary>
        /// Abstract method to get a message by Id.
        /// </summary>
        /// <param name="id">The id of the message.</param>
        /// <returns>The messageDto object.</returns>
        Task<ActionResult<Message>> GetMessageAsync(int id);

        /// <summary>
        /// Abstract method to create a message.
        /// </summary>
        /// <param name="message">Message object.</param>
        /// <returns>The new message object</returns>
        Task<ActionResult<Message>> PostMessageAsync(Message message);

        /// <summary>
        /// Abstract method to update a message.
        /// </summary>
        /// <param name="id">The id of the message</param>
        /// <param name="messageDto">MessageDto object</param>
        /// <returns>MessageDto object.</returns>
        Task<ActionResult<Message>> PutMessageAsync(int id, MessageUpdateDTO messageDto);

        /// <summary>
        /// Abstract method to delete a message.
        /// </summary>
        /// <param name="id">The id of the message</param>
        /// <returns></returns>
        Task<ActionResult<Message>> DeleteMessageAsync(int id);

    }
}
