using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.product{
	
	
	
	
	
	public class Spu {
		
		///<summary>
		/// ean
		///</summary>
		
		private string ean_;
		
		///<summary>
		/// is_online
		///</summary>
		
		private byte? isOnline_;
		
		///<summary>
		/// unit
		///</summary>
		
		private string unit_;
		
		///<summary>
		/// upc
		///</summary>
		
		private string upc_;
		
		///<summary>
		/// product_name
		///</summary>
		
		private string productName_;
		
		///<summary>
		/// category_id
		///</summary>
		
		private string categoryId_;
		
		///<summary>
		/// step_quantity
		///</summary>
		
		private string stepQuantity_;
		
		///<summary>
		/// short_description
		///</summary>
		
		private string shortDescription_;
		
		///<summary>
		/// long_description
		///</summary>
		
		private string longDescription_;
		
		///<summary>
		/// min_order_quantity
		///</summary>
		
		private int? minOrderQuantity_;
		
		///<summary>
		/// is_searchable
		///</summary>
		
		private byte? isSearchable_;
		
		///<summary>
		/// tax_class_id
		///</summary>
		
		private string taxClassId_;
		
		///<summary>
		/// is_available
		///</summary>
		
		private byte? isAvailable_;
		
		///<summary>
		/// status
		///</summary>
		
		private byte? status_;
		
		///<summary>
		/// brand
		///</summary>
		
		private string brand_;
		
		///<summary>
		/// variations
		///</summary>
		
		private string variations_;
		
		///<summary>
		/// sftp_file_log_id
		///</summary>
		
		private string sftpFileLogId_;
		
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
		public string GetUnit(){
			return this.unit_;
		}
		
		public void SetUnit(string value){
			this.unit_ = value;
		}
		public string GetUpc(){
			return this.upc_;
		}
		
		public void SetUpc(string value){
			this.upc_ = value;
		}
		public string GetProductName(){
			return this.productName_;
		}
		
		public void SetProductName(string value){
			this.productName_ = value;
		}
		public string GetCategoryId(){
			return this.categoryId_;
		}
		
		public void SetCategoryId(string value){
			this.categoryId_ = value;
		}
		public string GetStepQuantity(){
			return this.stepQuantity_;
		}
		
		public void SetStepQuantity(string value){
			this.stepQuantity_ = value;
		}
		public string GetShortDescription(){
			return this.shortDescription_;
		}
		
		public void SetShortDescription(string value){
			this.shortDescription_ = value;
		}
		public string GetLongDescription(){
			return this.longDescription_;
		}
		
		public void SetLongDescription(string value){
			this.longDescription_ = value;
		}
		public int? GetMinOrderQuantity(){
			return this.minOrderQuantity_;
		}
		
		public void SetMinOrderQuantity(int? value){
			this.minOrderQuantity_ = value;
		}
		public byte? GetIsSearchable(){
			return this.isSearchable_;
		}
		
		public void SetIsSearchable(byte? value){
			this.isSearchable_ = value;
		}
		public string GetTaxClassId(){
			return this.taxClassId_;
		}
		
		public void SetTaxClassId(string value){
			this.taxClassId_ = value;
		}
		public byte? GetIsAvailable(){
			return this.isAvailable_;
		}
		
		public void SetIsAvailable(byte? value){
			this.isAvailable_ = value;
		}
		public byte? GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(byte? value){
			this.status_ = value;
		}
		public string GetBrand(){
			return this.brand_;
		}
		
		public void SetBrand(string value){
			this.brand_ = value;
		}
		public string GetVariations(){
			return this.variations_;
		}
		
		public void SetVariations(string value){
			this.variations_ = value;
		}
		public string GetSftpFileLogId(){
			return this.sftpFileLogId_;
		}
		
		public void SetSftpFileLogId(string value){
			this.sftpFileLogId_ = value;
		}
		public byte? GetIsDeleted(){
			return this.isDeleted_;
		}
		
		public void SetIsDeleted(byte? value){
			this.isDeleted_ = value;
		}
		
	}
	
}