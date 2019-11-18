using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.product{
	
	
	
	
	
	public class Sku {
		
		///<summary>
		/// ean
		///</summary>
		
		private string ean_;
		
		///<summary>
		/// is_online
		///</summary>
		
		private byte? isOnline_;
		
		///<summary>
		/// size
		///</summary>
		
		private string size_;
		
		///<summary>
		/// tax_class_id
		///</summary>
		
		private string taxClassId_;
		
		///<summary>
		/// color
		///</summary>
		
		private string color_;
		
		///<summary>
		/// sftp_file_log_id
		///</summary>
		
		private string sftpFileLogId_;
		
		///<summary>
		/// status
		///</summary>
		
		private byte? status_;
		
		///<summary>
		/// is_deleted
		///</summary>
		
		private byte? isDeleted_;
		
		public string GetEan(){
			return this.ean_;
		}
		
		public void SetEan(string value){
			this.ean_ = value;
		}
		public byte? GetIsOnline(){
			return this.isOnline_;
		}
		
		public void SetIsOnline(byte? value){
			this.isOnline_ = value;
		}
		public string GetSize(){
			return this.size_;
		}
		
		public void SetSize(string value){
			this.size_ = value;
		}
		public string GetTaxClassId(){
			return this.taxClassId_;
		}
		
		public void SetTaxClassId(string value){
			this.taxClassId_ = value;
		}
		public string GetColor(){
			return this.color_;
		}
		
		public void SetColor(string value){
			this.color_ = value;
		}
		public string GetSftpFileLogId(){
			return this.sftpFileLogId_;
		}
		
		public void SetSftpFileLogId(string value){
			this.sftpFileLogId_ = value;
		}
		public byte? GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(byte? value){
			this.status_ = value;
		}
		public byte? GetIsDeleted(){
			return this.isDeleted_;
		}
		
		public void SetIsDeleted(byte? value){
			this.isDeleted_ = value;
		}
		
	}
	
}