using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.product{
	
	
	
	
	
	public class SkuDetail {
		
		///<summary>
		/// 商品图片长图:根据图号（image_index）区分 图号取值如下：展示图：1、2、3、4、15、16、17、18、19、20、21、22列表图：5、7 详情图：601、602……650 透明底图：30
		///</summary>
		
		private List<com.vip.vop.cup.api.product.ItemImage> item_images_;
		
		///<summary>
		/// 商品图片方图:根据图号（image_index）区分图号取值如下：展示图：1、2、3、4、15、16、17、18、19、20、21、22 列表图：5、7 详情图：601、602……650 透明底图：30建议优先使用方图
		///</summary>
		
		private List<com.vip.vop.cup.api.product.ItemImage> square_images_;
		
		///<summary>
		/// 颜色
		///</summary>
		
		private string color_;
		
		///<summary>
		/// 尺码
		///</summary>
		
		private string size_;
		
		///<summary>
		/// prodSpuId
		///</summary>
		
		private string prod_spu_id_;
		
		///<summary>
		/// 商品详细尺码ID
		///</summary>
		
		private long? size_detail_id_;
		
		///<summary>
		/// 商品条形码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 色号
		///</summary>
		
		private string gsn_;
		
		///<summary>
		/// 是否有效期管理
		///</summary>
		
		private string is_expiration_management_;
		
		///<summary>
		/// 保质期天数
		///</summary>
		
		private int? expiration_days_;
		
		///<summary>
		/// 收货截止期限天数
		///</summary>
		
		private int? acceptance_deadline_;
		
		///<summary>
		/// 售卖截止期限天数
		///</summary>
		
		private int? sale_deadline_;
		
		///<summary>
		/// 保险期天数
		///</summary>
		
		private int? insurance_days_;
		
		///<summary>
		/// 国产/进口
		///</summary>
		
		private int? made_in_;
		
		///<summary>
		/// 是否序列号管理
		///</summary>
		
		private string is_sequence_management_;
		
		///<summary>
		/// 是否可退货标识，0=可退，1=不可退，2=审核可退
		///</summary>
		
		private int? support_return_;
		
		public List<com.vip.vop.cup.api.product.ItemImage> GetItem_images(){
			return this.item_images_;
		}
		
		public void SetItem_images(List<com.vip.vop.cup.api.product.ItemImage> value){
			this.item_images_ = value;
		}
		public List<com.vip.vop.cup.api.product.ItemImage> GetSquare_images(){
			return this.square_images_;
		}
		
		public void SetSquare_images(List<com.vip.vop.cup.api.product.ItemImage> value){
			this.square_images_ = value;
		}
		public string GetColor(){
			return this.color_;
		}
		
		public void SetColor(string value){
			this.color_ = value;
		}
		public string GetSize(){
			return this.size_;
		}
		
		public void SetSize(string value){
			this.size_ = value;
		}
		public string GetProd_spu_id(){
			return this.prod_spu_id_;
		}
		
		public void SetProd_spu_id(string value){
			this.prod_spu_id_ = value;
		}
		public long? GetSize_detail_id(){
			return this.size_detail_id_;
		}
		
		public void SetSize_detail_id(long? value){
			this.size_detail_id_ = value;
		}
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		public string GetGsn(){
			return this.gsn_;
		}
		
		public void SetGsn(string value){
			this.gsn_ = value;
		}
		public string GetIs_expiration_management(){
			return this.is_expiration_management_;
		}
		
		public void SetIs_expiration_management(string value){
			this.is_expiration_management_ = value;
		}
		public int? GetExpiration_days(){
			return this.expiration_days_;
		}
		
		public void SetExpiration_days(int? value){
			this.expiration_days_ = value;
		}
		public int? GetAcceptance_deadline(){
			return this.acceptance_deadline_;
		}
		
		public void SetAcceptance_deadline(int? value){
			this.acceptance_deadline_ = value;
		}
		public int? GetSale_deadline(){
			return this.sale_deadline_;
		}
		
		public void SetSale_deadline(int? value){
			this.sale_deadline_ = value;
		}
		public int? GetInsurance_days(){
			return this.insurance_days_;
		}
		
		public void SetInsurance_days(int? value){
			this.insurance_days_ = value;
		}
		public int? GetMade_in(){
			return this.made_in_;
		}
		
		public void SetMade_in(int? value){
			this.made_in_ = value;
		}
		public string GetIs_sequence_management(){
			return this.is_sequence_management_;
		}
		
		public void SetIs_sequence_management(string value){
			this.is_sequence_management_ = value;
		}
		public int? GetSupport_return(){
			return this.support_return_;
		}
		
		public void SetSupport_return(int? value){
			this.support_return_ = value;
		}
		
	}
	
}