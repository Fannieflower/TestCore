using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.product{
	
	
	
	
	
	public class ItemImage {
		
		///<summary>
		/// ProductSkuId
		///</summary>
		
		private long? item_id_;
		
		///<summary>
		/// 描述信息
		///</summary>
		
		private string description_;
		
		///<summary>
		/// 图片URI
		///</summary>
		
		private string image_url_;
		
		///<summary>
		/// 图片类型，jpg/png/gif
		///</summary>
		
		private string image_type_;
		
		///<summary>
		/// 商品规格，如210x210, 100x100
		///</summary>
		
		private string image_size_;
		
		///<summary>
		/// 图片排序
		///</summary>
		
		private int? image_index_;
		
		///<summary>
		/// 操作类型
		///</summary>
		
		private com.vip.vop.cup.api.product.OperationMode? operation_mode_;
		
		///<summary>
		/// 图片状态，0:成功状态；1：最终uri待转换；2：临时uri待转换；3：其它
		///</summary>
		
		private short? status_;
		
		public long? GetItem_id(){
			return this.item_id_;
		}
		
		public void SetItem_id(long? value){
			this.item_id_ = value;
		}
		public string GetDescription(){
			return this.description_;
		}
		
		public void SetDescription(string value){
			this.description_ = value;
		}
		public string GetImage_url(){
			return this.image_url_;
		}
		
		public void SetImage_url(string value){
			this.image_url_ = value;
		}
		public string GetImage_type(){
			return this.image_type_;
		}
		
		public void SetImage_type(string value){
			this.image_type_ = value;
		}
		public string GetImage_size(){
			return this.image_size_;
		}
		
		public void SetImage_size(string value){
			this.image_size_ = value;
		}
		public int? GetImage_index(){
			return this.image_index_;
		}
		
		public void SetImage_index(int? value){
			this.image_index_ = value;
		}
		public com.vip.vop.cup.api.product.OperationMode? GetOperation_mode(){
			return this.operation_mode_;
		}
		
		public void SetOperation_mode(com.vip.vop.cup.api.product.OperationMode? value){
			this.operation_mode_ = value;
		}
		public short? GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(short? value){
			this.status_ = value;
		}
		
	}
	
}