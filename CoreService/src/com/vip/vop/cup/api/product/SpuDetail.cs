using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.product{
	
	
	
	
	
	public class SpuDetail {
		
		///<summary>
		/// 商品名称
		///</summary>
		
		private string title_;
		
		///<summary>
		/// 短视频
		///</summary>
		
		private string short_video_;
		
		///<summary>
		/// 长视频
		///</summary>
		
		private string long_video_;
		
		///<summary>
		/// 核心描述
		///</summary>
		
		private string sub_title_;
		
		///<summary>
		/// 商品分类
		///</summary>
		
		private int? category_id_;
		
		///<summary>
		/// 品牌中文名
		///</summary>
		
		private string brand_cn_name_;
		
		///<summary>
		/// 品牌英文名
		///</summary>
		
		private string brand_en_name_;
		
		///<summary>
		/// 长度（mm）
		///</summary>
		
		private int? length_;
		
		///<summary>
		/// 宽度（mm）
		///</summary>
		
		private int? width_;
		
		///<summary>
		/// 高度（mm）
		///</summary>
		
		private int? height_;
		
		///<summary>
		/// 净重（g）
		///</summary>
		
		private int? weight_;
		
		///<summary>
		/// 毛重（g）
		///</summary>
		
		private int? gross_weight_;
		
		///<summary>
		/// 商品属性，比如：适用季节，春
		///</summary>
		
		private Dictionary<string, string> flat_spec_props_;
		
		///<summary>
		/// 自定义属性
		///</summary>
		
		private List<com.vip.vop.cup.api.product.ItemProperty> item_properties_;
		
		///<summary>
		/// 尺码表
		///</summary>
		
		private com.vip.vop.cup.api.product.SizeTable size_table_;
		
		///<summary>
		/// 移动端测量示意图
		///</summary>
		
		private string app_measurement_diagram_;
		
		///<summary>
		/// PC端测量示意图
		///</summary>
		
		private string pc_measurement_diagram_;
		
		///<summary>
		/// 商品分类名称
		///</summary>
		
		private string name_;
		
		///<summary>
		/// 商品款号
		///</summary>
		
		private string sn_;
		
		///<summary>
		/// 商品品牌id
		///</summary>
		
		private int? brand_id_;
		
		///<summary>
		/// 产地
		///</summary>
		
		private string area_output_;
		
		///<summary>
		/// 是否易碎品
		///</summary>
		
		private bool? is_fragile_;
		
		///<summary>
		/// 是否大件品
		///</summary>
		
		private bool? is_large_;
		
		///<summary>
		/// 是否贵重品
		///</summary>
		
		private bool? is_precious_;
		
		///<summary>
		/// 配件信息
		///</summary>
		
		private string accessory_info_;
		
		///<summary>
		/// 售后说明
		///</summary>
		
		private string sale_service_;
		
		///<summary>
		/// 增值税税率
		///</summary>
		
		private double? tax_rate_;
		
		///<summary>
		/// 洗涤说明
		///</summary>
		
		private string washing_instruct_;
		
		///<summary>
		/// 一级类目id
		///</summary>
		
		private int? top_category_id_;
		
		///<summary>
		/// 二级类目id
		///</summary>
		
		private int? sub_category_id_;
		
		///<summary>
		/// 是否航空禁运品
		///</summary>
		
		private bool? is_embargo_;
		
		///<summary>
		/// 选品时间，格式为'yyyy-MM-dd HH:mm:ss'
		///</summary>
		
		private string create_time_;
		
		///<summary>
		/// 是否美妆，0=否，1=是
		///</summary>
		
		private int? make_up_flag_;
		
		///<summary>
		/// 商品属性列表
		///</summary>
		
		private List<com.vip.vop.cup.api.product.Attribute> attr_spec_props_;
		
		///<summary>
		/// 商品图片信息
		///</summary>
		
		private List<com.vip.vop.cup.api.product.ItemImage> item_images_;
		
		///<summary>
		/// 商品图片信息（方图）
		///</summary>
		
		private List<com.vip.vop.cup.api.product.ItemImage> square_images_;
		
		///<summary>
		/// 商品吊牌价（仅针对新零售有值)
		///</summary>
		
		private double? market_price_;
		
		///<summary>
		/// 商品适用季节（仅针对新零售有值)
		///</summary>
		
		private string season_;
		
		///<summary>
		/// 商品适用性别(仅针对新零售有值)
		///</summary>
		
		private string gender_;
		
		///<summary>
		/// 商品税目编码(仅针对新零售有值)
		///</summary>
		
		private string tax_code_;
		
		public string GetTitle(){
			return this.title_;
		}
		
		public void SetTitle(string value){
			this.title_ = value;
		}
		public string GetShort_video(){
			return this.short_video_;
		}
		
		public void SetShort_video(string value){
			this.short_video_ = value;
		}
		public string GetLong_video(){
			return this.long_video_;
		}
		
		public void SetLong_video(string value){
			this.long_video_ = value;
		}
		public string GetSub_title(){
			return this.sub_title_;
		}
		
		public void SetSub_title(string value){
			this.sub_title_ = value;
		}
		public int? GetCategory_id(){
			return this.category_id_;
		}
		
		public void SetCategory_id(int? value){
			this.category_id_ = value;
		}
		public string GetBrand_cn_name(){
			return this.brand_cn_name_;
		}
		
		public void SetBrand_cn_name(string value){
			this.brand_cn_name_ = value;
		}
		public string GetBrand_en_name(){
			return this.brand_en_name_;
		}
		
		public void SetBrand_en_name(string value){
			this.brand_en_name_ = value;
		}
		public int? GetLength(){
			return this.length_;
		}
		
		public void SetLength(int? value){
			this.length_ = value;
		}
		public int? GetWidth(){
			return this.width_;
		}
		
		public void SetWidth(int? value){
			this.width_ = value;
		}
		public int? GetHeight(){
			return this.height_;
		}
		
		public void SetHeight(int? value){
			this.height_ = value;
		}
		public int? GetWeight(){
			return this.weight_;
		}
		
		public void SetWeight(int? value){
			this.weight_ = value;
		}
		public int? GetGross_weight(){
			return this.gross_weight_;
		}
		
		public void SetGross_weight(int? value){
			this.gross_weight_ = value;
		}
		public Dictionary<string, string> GetFlat_spec_props(){
			return this.flat_spec_props_;
		}
		
		public void SetFlat_spec_props(Dictionary<string, string> value){
			this.flat_spec_props_ = value;
		}
		public List<com.vip.vop.cup.api.product.ItemProperty> GetItem_properties(){
			return this.item_properties_;
		}
		
		public void SetItem_properties(List<com.vip.vop.cup.api.product.ItemProperty> value){
			this.item_properties_ = value;
		}
		public com.vip.vop.cup.api.product.SizeTable GetSize_table(){
			return this.size_table_;
		}
		
		public void SetSize_table(com.vip.vop.cup.api.product.SizeTable value){
			this.size_table_ = value;
		}
		public string GetApp_measurement_diagram(){
			return this.app_measurement_diagram_;
		}
		
		public void SetApp_measurement_diagram(string value){
			this.app_measurement_diagram_ = value;
		}
		public string GetPc_measurement_diagram(){
			return this.pc_measurement_diagram_;
		}
		
		public void SetPc_measurement_diagram(string value){
			this.pc_measurement_diagram_ = value;
		}
		public string GetName(){
			return this.name_;
		}
		
		public void SetName(string value){
			this.name_ = value;
		}
		public string GetSn(){
			return this.sn_;
		}
		
		public void SetSn(string value){
			this.sn_ = value;
		}
		public int? GetBrand_id(){
			return this.brand_id_;
		}
		
		public void SetBrand_id(int? value){
			this.brand_id_ = value;
		}
		public string GetArea_output(){
			return this.area_output_;
		}
		
		public void SetArea_output(string value){
			this.area_output_ = value;
		}
		public bool? GetIs_fragile(){
			return this.is_fragile_;
		}
		
		public void SetIs_fragile(bool? value){
			this.is_fragile_ = value;
		}
		public bool? GetIs_large(){
			return this.is_large_;
		}
		
		public void SetIs_large(bool? value){
			this.is_large_ = value;
		}
		public bool? GetIs_precious(){
			return this.is_precious_;
		}
		
		public void SetIs_precious(bool? value){
			this.is_precious_ = value;
		}
		public string GetAccessory_info(){
			return this.accessory_info_;
		}
		
		public void SetAccessory_info(string value){
			this.accessory_info_ = value;
		}
		public string GetSale_service(){
			return this.sale_service_;
		}
		
		public void SetSale_service(string value){
			this.sale_service_ = value;
		}
		public double? GetTax_rate(){
			return this.tax_rate_;
		}
		
		public void SetTax_rate(double? value){
			this.tax_rate_ = value;
		}
		public string GetWashing_instruct(){
			return this.washing_instruct_;
		}
		
		public void SetWashing_instruct(string value){
			this.washing_instruct_ = value;
		}
		public int? GetTop_category_id(){
			return this.top_category_id_;
		}
		
		public void SetTop_category_id(int? value){
			this.top_category_id_ = value;
		}
		public int? GetSub_category_id(){
			return this.sub_category_id_;
		}
		
		public void SetSub_category_id(int? value){
			this.sub_category_id_ = value;
		}
		public bool? GetIs_embargo(){
			return this.is_embargo_;
		}
		
		public void SetIs_embargo(bool? value){
			this.is_embargo_ = value;
		}
		public string GetCreate_time(){
			return this.create_time_;
		}
		
		public void SetCreate_time(string value){
			this.create_time_ = value;
		}
		public int? GetMake_up_flag(){
			return this.make_up_flag_;
		}
		
		public void SetMake_up_flag(int? value){
			this.make_up_flag_ = value;
		}
		public List<com.vip.vop.cup.api.product.Attribute> GetAttr_spec_props(){
			return this.attr_spec_props_;
		}
		
		public void SetAttr_spec_props(List<com.vip.vop.cup.api.product.Attribute> value){
			this.attr_spec_props_ = value;
		}
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
		public double? GetMarket_price(){
			return this.market_price_;
		}
		
		public void SetMarket_price(double? value){
			this.market_price_ = value;
		}
		public string GetSeason(){
			return this.season_;
		}
		
		public void SetSeason(string value){
			this.season_ = value;
		}
		public string GetGender(){
			return this.gender_;
		}
		
		public void SetGender(string value){
			this.gender_ = value;
		}
		public string GetTax_code(){
			return this.tax_code_;
		}
		
		public void SetTax_code(string value){
			this.tax_code_ = value;
		}
		
	}
	
}