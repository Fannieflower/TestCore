using System.Collections.Generic;
using vipapis_S = vipapis;
namespace com.vip.tpc.api.model
{





    public class TakingAwayGoodsRequest {
		
		///<summary>
		/// 唯品会订单号，唯品会客户订单
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 揽件作业指令：31：承运商接单；32：派单指定快递员；34：快递员准备上门；35：揽件成功；36：揽件失败；4：揽件异常
		///</summary>
		
		private string status_;
		
		///<summary>
		/// 揽收类型
		///</summary>
		
		private string type_;
		
		///<summary>
		/// 小件员姓名，status= 32时，为必填项
		///</summary>
		
		private string deliverymanName_;
		
		///<summary>
		/// 快递电话，collectStatus = 32时，为必填项
		///</summary>
		
		private string contactNumber_;
		
		///<summary>
		/// 状态时间，Unix时间戳 精度：秒
		///</summary>
		
		private long? time_;
		
		///<summary>
		/// 运单号
		///</summary>
		
		private string transportNo_;
		
		///<summary>
		/// 重量，单位千克（KG）保留两位小数 揽收成功（collectStatus=35）时必填
		///</summary>
		
		private string weight_;
		
		///<summary>
		/// 体积，单位为立方米（m³）保留4位小数
		///</summary>
		
		private string volume_;
		
		///<summary>
		/// 操作人
		///</summary>
		
		private string operator_;
		
		///<summary>
		/// 裹明细，揽收成功（collectStatus=35）时必填 【按业务要求一次揽收只能使用一个包裹，支持多行商品记录】
		///</summary>
		
		private List<vipapis_S.tpc.service.GoodsPack> packs_;
		
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public string GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(string value){
			this.status_ = value;
		}
		public string GetType(){
			return this.type_;
		}
		
		public void SetType(string value){
			this.type_ = value;
		}
		public string GetDeliverymanName(){
			return this.deliverymanName_;
		}
		
		public void SetDeliverymanName(string value){
			this.deliverymanName_ = value;
		}
		public string GetContactNumber(){
			return this.contactNumber_;
		}
		
		public void SetContactNumber(string value){
			this.contactNumber_ = value;
		}
		public long? GetTime(){
			return this.time_;
		}
		
		public void SetTime(long? value){
			this.time_ = value;
		}
		public string GetTransportNo(){
			return this.transportNo_;
		}
		
		public void SetTransportNo(string value){
			this.transportNo_ = value;
		}
		public string GetWeight(){
			return this.weight_;
		}
		
		public void SetWeight(string value){
			this.weight_ = value;
		}
		public string GetVolume(){
			return this.volume_;
		}
		
		public void SetVolume(string value){
			this.volume_ = value;
		}
		public string GetOperator(){
			return this.operator_;
		}
		
		public void SetOperator(string value){
			this.operator_ = value;
		}
		public List<vipapis_S.tpc.service.GoodsPack> GetPacks(){
			return this.packs_;
		}
		
		public void SetPacks(List<vipapis_S.tpc.service.GoodsPack> value){
			this.packs_ = value;
		}
		
	}
	
}