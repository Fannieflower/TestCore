using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.pms.data.service{
	
	
	public class PmsDataServiceHelper {
		
		
		
		public class addActivityUserLog_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.ActivityUserLogRequestModel request_;
			
			public com.vip.pms.data.service.ActivityUserLogRequestModel GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.pms.data.service.ActivityUserLogRequestModel value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class addCommandPersonalCode_args {
			
			///<summary>
			///</summary>
			
			private string commandId_;
			
			///<summary>
			///</summary>
			
			private string personalCode_;
			
			public string GetCommandId(){
				return this.commandId_;
			}
			
			public void SetCommandId(string value){
				this.commandId_ = value;
			}
			public string GetPersonalCode(){
				return this.personalCode_;
			}
			
			public void SetPersonalCode(string value){
				this.personalCode_ = value;
			}
			
		}
		
		
		
		
		public class addCommandUserLog_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.CommandUserLogRequestModel request_;
			
			public com.vip.pms.data.service.CommandUserLogRequestModel GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.pms.data.service.CommandUserLogRequestModel value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class addCouponUserLog_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.CouponOrderRequestModel request_;
			
			public com.vip.pms.data.service.CouponOrderRequestModel GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.pms.data.service.CouponOrderRequestModel value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class addOldPmsOrderInfo_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.OldPmsOrderRequestModel request_;
			
			public com.vip.pms.data.service.OldPmsOrderRequestModel GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.pms.data.service.OldPmsOrderRequestModel value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class addOrUpdateActivitySync_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.ActivityRequestModel activityRequestModel_;
			
			public com.vip.pms.data.service.ActivityRequestModel GetActivityRequestModel(){
				return this.activityRequestModel_;
			}
			
			public void SetActivityRequestModel(com.vip.pms.data.service.ActivityRequestModel value){
				this.activityRequestModel_ = value;
			}
			
		}
		
		
		
		
		public class addOrUpdateCommandSync_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.CommandRequestModel commandRequestModel_;
			
			public com.vip.pms.data.service.CommandRequestModel GetCommandRequestModel(){
				return this.commandRequestModel_;
			}
			
			public void SetCommandRequestModel(com.vip.pms.data.service.CommandRequestModel value){
				this.commandRequestModel_ = value;
			}
			
		}
		
		
		
		
		public class addOrUpdateConfig_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.AdminConfigModel config_;
			
			public com.vip.pms.data.service.AdminConfigModel GetConfig(){
				return this.config_;
			}
			
			public void SetConfig(com.vip.pms.data.service.AdminConfigModel value){
				this.config_ = value;
			}
			
		}
		
		
		
		
		public class addOrUpdateCouponGroupSync_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.CouponRequestModel couponRequestModel_;
			
			public com.vip.pms.data.service.CouponRequestModel GetCouponRequestModel(){
				return this.couponRequestModel_;
			}
			
			public void SetCouponRequestModel(com.vip.pms.data.service.CouponRequestModel value){
				this.couponRequestModel_ = value;
			}
			
		}
		
		
		
		
		public class addOrUpdateCouponRuleSync_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.CouponRuleRequestModel couponRuleRequestModel_;
			
			public com.vip.pms.data.service.CouponRuleRequestModel GetCouponRuleRequestModel(){
				return this.couponRuleRequestModel_;
			}
			
			public void SetCouponRuleRequestModel(com.vip.pms.data.service.CouponRuleRequestModel value){
				this.couponRuleRequestModel_ = value;
			}
			
		}
		
		
		
		
		public class addOrUpdateCouponSync_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.CouponRequestModel couponRequestModel_;
			
			public com.vip.pms.data.service.CouponRequestModel GetCouponRequestModel(){
				return this.couponRequestModel_;
			}
			
			public void SetCouponRequestModel(com.vip.pms.data.service.CouponRequestModel value){
				this.couponRequestModel_ = value;
			}
			
		}
		
		
		
		
		public class addOrUpdatePaySync_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.PayRequestModel payRequestModel_;
			
			public com.vip.pms.data.service.PayRequestModel GetPayRequestModel(){
				return this.payRequestModel_;
			}
			
			public void SetPayRequestModel(com.vip.pms.data.service.PayRequestModel value){
				this.payRequestModel_ = value;
			}
			
		}
		
		
		
		
		public class addOrUpdatePrepayInfoSync_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.PrepayInfoRequestModel prepayInfoRequestModel_;
			
			public com.vip.pms.data.service.PrepayInfoRequestModel GetPrepayInfoRequestModel(){
				return this.prepayInfoRequestModel_;
			}
			
			public void SetPrepayInfoRequestModel(com.vip.pms.data.service.PrepayInfoRequestModel value){
				this.prepayInfoRequestModel_ = value;
			}
			
		}
		
		
		
		
		public class addOrUpdateSpecialSync_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.SpecialRequestModel specialRequestModel_;
			
			public com.vip.pms.data.service.SpecialRequestModel GetSpecialRequestModel(){
				return this.specialRequestModel_;
			}
			
			public void SetSpecialRequestModel(com.vip.pms.data.service.SpecialRequestModel value){
				this.specialRequestModel_ = value;
			}
			
		}
		
		
		
		
		public class addOrUpdateSurprisePriceActivitySync_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.SurprisePriceActivityRequestModel activityRequestModel_;
			
			public com.vip.pms.data.service.SurprisePriceActivityRequestModel GetActivityRequestModel(){
				return this.activityRequestModel_;
			}
			
			public void SetActivityRequestModel(com.vip.pms.data.service.SurprisePriceActivityRequestModel value){
				this.activityRequestModel_ = value;
			}
			
		}
		
		
		
		
		public class addPayUserLog_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.PayUserLogRequestModel request_;
			
			public com.vip.pms.data.service.PayUserLogRequestModel GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.pms.data.service.PayUserLogRequestModel value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class addSpecialUserLog_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.SpecialUserLogRequestModel request_;
			
			public com.vip.pms.data.service.SpecialUserLogRequestModel GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.pms.data.service.SpecialUserLogRequestModel value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class batchModifyCouponTime_args {
			
			///<summary>
			///</summary>
			
			private List<com.vip.pms.data.service.ModifyInfoRequestModel> modifyList_;
			
			///<summary>
			/// 任务ID
			///</summary>
			
			private string taskId_;
			
			public List<com.vip.pms.data.service.ModifyInfoRequestModel> GetModifyList(){
				return this.modifyList_;
			}
			
			public void SetModifyList(List<com.vip.pms.data.service.ModifyInfoRequestModel> value){
				this.modifyList_ = value;
			}
			public string GetTaskId(){
				return this.taskId_;
			}
			
			public void SetTaskId(string value){
				this.taskId_ = value;
			}
			
		}
		
		
		
		
		public class buildAllActivityIndex_args {
			
			///<summary>
			///</summary>
			
			private string indexType_;
			
			public string GetIndexType(){
				return this.indexType_;
			}
			
			public void SetIndexType(string value){
				this.indexType_ = value;
			}
			
		}
		
		
		
		
		public class cancelActivitySync_args {
			
			///<summary>
			///</summary>
			
			private List<string> actNoList_;
			
			///<summary>
			///</summary>
			
			private long? channelId_;
			
			public List<string> GetActNoList(){
				return this.actNoList_;
			}
			
			public void SetActNoList(List<string> value){
				this.actNoList_ = value;
			}
			public long? GetChannelId(){
				return this.channelId_;
			}
			
			public void SetChannelId(long? value){
				this.channelId_ = value;
			}
			
		}
		
		
		
		
		public class cancelCommandSync_args {
			
			///<summary>
			///</summary>
			
			private List<string> commandNoList_;
			
			public List<string> GetCommandNoList(){
				return this.commandNoList_;
			}
			
			public void SetCommandNoList(List<string> value){
				this.commandNoList_ = value;
			}
			
		}
		
		
		
		
		public class cancelOrOfflineCouponGroupSync_args {
			
			///<summary>
			///</summary>
			
			private List<string> noList_;
			
			///<summary>
			///</summary>
			
			private bool? isCancel_;
			
			public List<string> GetNoList(){
				return this.noList_;
			}
			
			public void SetNoList(List<string> value){
				this.noList_ = value;
			}
			public bool? GetIsCancel(){
				return this.isCancel_;
			}
			
			public void SetIsCancel(bool? value){
				this.isCancel_ = value;
			}
			
		}
		
		
		
		
		public class cancelOrOfflineCouponRuleSync_args {
			
			///<summary>
			///</summary>
			
			private List<string> noList_;
			
			///<summary>
			///</summary>
			
			private bool? isCancel_;
			
			public List<string> GetNoList(){
				return this.noList_;
			}
			
			public void SetNoList(List<string> value){
				this.noList_ = value;
			}
			public bool? GetIsCancel(){
				return this.isCancel_;
			}
			
			public void SetIsCancel(bool? value){
				this.isCancel_ = value;
			}
			
		}
		
		
		
		
		public class cancelOrOfflineCouponSync_args {
			
			///<summary>
			///</summary>
			
			private List<string> noList_;
			
			///<summary>
			///</summary>
			
			private bool? isCancel_;
			
			public List<string> GetNoList(){
				return this.noList_;
			}
			
			public void SetNoList(List<string> value){
				this.noList_ = value;
			}
			public bool? GetIsCancel(){
				return this.isCancel_;
			}
			
			public void SetIsCancel(bool? value){
				this.isCancel_ = value;
			}
			
		}
		
		
		
		
		public class cancelOrder_args {
			
			///<summary>
			///</summary>
			
			private string orderNo_;
			
			///<summary>
			///</summary>
			
			private byte? refIdType_;
			
			///<summary>
			///</summary>
			
			private List<long?> refIdList_;
			
			///<summary>
			///</summary>
			
			private long? userId_;
			
			public string GetOrderNo(){
				return this.orderNo_;
			}
			
			public void SetOrderNo(string value){
				this.orderNo_ = value;
			}
			public byte? GetRefIdType(){
				return this.refIdType_;
			}
			
			public void SetRefIdType(byte? value){
				this.refIdType_ = value;
			}
			public List<long?> GetRefIdList(){
				return this.refIdList_;
			}
			
			public void SetRefIdList(List<long?> value){
				this.refIdList_ = value;
			}
			public long? GetUserId(){
				return this.userId_;
			}
			
			public void SetUserId(long? value){
				this.userId_ = value;
			}
			
		}
		
		
		
		
		public class cancelPaySync_args {
			
			///<summary>
			///</summary>
			
			private List<string> payNoList_;
			
			public List<string> GetPayNoList(){
				return this.payNoList_;
			}
			
			public void SetPayNoList(List<string> value){
				this.payNoList_ = value;
			}
			
		}
		
		
		
		
		public class cancelSpecialSync_args {
			
			///<summary>
			///</summary>
			
			private List<string> specialNoList_;
			
			public List<string> GetSpecialNoList(){
				return this.specialNoList_;
			}
			
			public void SetSpecialNoList(List<string> value){
				this.specialNoList_ = value;
			}
			
		}
		
		
		
		
		public class cancelSurprisePriceActivitySync_args {
			
			///<summary>
			///</summary>
			
			private List<string> actNoList_;
			
			public List<string> GetActNoList(){
				return this.actNoList_;
			}
			
			public void SetActNoList(List<string> value){
				this.actNoList_ = value;
			}
			
		}
		
		
		
		
		public class check_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.CheckRequest checkRequest_;
			
			public com.vip.pms.data.service.CheckRequest GetCheckRequest(){
				return this.checkRequest_;
			}
			
			public void SetCheckRequest(com.vip.pms.data.service.CheckRequest value){
				this.checkRequest_ = value;
			}
			
		}
		
		
		
		
		public class couponActivate_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.CouponInstanceModel instanceModel_;
			
			public com.vip.pms.data.service.CouponInstanceModel GetInstanceModel(){
				return this.instanceModel_;
			}
			
			public void SetInstanceModel(com.vip.pms.data.service.CouponInstanceModel value){
				this.instanceModel_ = value;
			}
			
		}
		
		
		
		
		public class couponBind_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.CouponInstanceModel instanceModel_;
			
			public com.vip.pms.data.service.CouponInstanceModel GetInstanceModel(){
				return this.instanceModel_;
			}
			
			public void SetInstanceModel(com.vip.pms.data.service.CouponInstanceModel value){
				this.instanceModel_ = value;
			}
			
		}
		
		
		
		
		public class couponGroupActivate_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.CouponInstanceModel groupInstanceModel_;
			
			///<summary>
			///</summary>
			
			private List<com.vip.pms.data.service.CouponInstanceModel> couponInstanceList_;
			
			public com.vip.pms.data.service.CouponInstanceModel GetGroupInstanceModel(){
				return this.groupInstanceModel_;
			}
			
			public void SetGroupInstanceModel(com.vip.pms.data.service.CouponInstanceModel value){
				this.groupInstanceModel_ = value;
			}
			public List<com.vip.pms.data.service.CouponInstanceModel> GetCouponInstanceList(){
				return this.couponInstanceList_;
			}
			
			public void SetCouponInstanceList(List<com.vip.pms.data.service.CouponInstanceModel> value){
				this.couponInstanceList_ = value;
			}
			
		}
		
		
		
		
		public class couponGroupBind_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.CouponInstanceModel groupInstanceModel_;
			
			///<summary>
			///</summary>
			
			private List<com.vip.pms.data.service.CouponInstanceModel> couponInstanceList_;
			
			public com.vip.pms.data.service.CouponInstanceModel GetGroupInstanceModel(){
				return this.groupInstanceModel_;
			}
			
			public void SetGroupInstanceModel(com.vip.pms.data.service.CouponInstanceModel value){
				this.groupInstanceModel_ = value;
			}
			public List<com.vip.pms.data.service.CouponInstanceModel> GetCouponInstanceList(){
				return this.couponInstanceList_;
			}
			
			public void SetCouponInstanceList(List<com.vip.pms.data.service.CouponInstanceModel> value){
				this.couponInstanceList_ = value;
			}
			
		}
		
		
		
		
		public class delGoodsOriginalPrice_args {
			
			///<summary>
			///</summary>
			
			private List<string> spuIdList_;
			
			public List<string> GetSpuIdList(){
				return this.spuIdList_;
			}
			
			public void SetSpuIdList(List<string> value){
				this.spuIdList_ = value;
			}
			
		}
		
		
		
		
		public class delGoodsSurprisePrice_args {
			
			///<summary>
			///</summary>
			
			private List<com.vip.pms.data.service.FlushGoodsSurprisePriceModel> modelList_;
			
			public List<com.vip.pms.data.service.FlushGoodsSurprisePriceModel> GetModelList(){
				return this.modelList_;
			}
			
			public void SetModelList(List<com.vip.pms.data.service.FlushGoodsSurprisePriceModel> value){
				this.modelList_ = value;
			}
			
		}
		
		
		
		
		public class deleteConfig_args {
			
			///<summary>
			///</summary>
			
			private string type_;
			
			///<summary>
			///</summary>
			
			private string key_;
			
			public string GetType(){
				return this.type_;
			}
			
			public void SetType(string value){
				this.type_ = value;
			}
			public string GetKey(){
				return this.key_;
			}
			
			public void SetKey(string value){
				this.key_ = value;
			}
			
		}
		
		
		
		
		public class deletePrepayInfoByMidSync_args {
			
			///<summary>
			///</summary>
			
			private string prepayMainNo_;
			
			///<summary>
			///</summary>
			
			private List<long?> merchandiseNos_;
			
			public string GetPrepayMainNo(){
				return this.prepayMainNo_;
			}
			
			public void SetPrepayMainNo(string value){
				this.prepayMainNo_ = value;
			}
			public List<long?> GetMerchandiseNos(){
				return this.merchandiseNos_;
			}
			
			public void SetMerchandiseNos(List<long?> value){
				this.merchandiseNos_ = value;
			}
			
		}
		
		
		
		
		public class deletePrepayInfoSync_args {
			
			///<summary>
			///</summary>
			
			private List<string> prepayMainNos_;
			
			public List<string> GetPrepayMainNos(){
				return this.prepayMainNos_;
			}
			
			public void SetPrepayMainNos(List<string> value){
				this.prepayMainNos_ = value;
			}
			
		}
		
		
		
		
		public class exportCoupon_args {
			
			///<summary>
			/// 券批次号
			///</summary>
			
			private string couponNo_;
			
			///<summary>
			/// 偏移量
			///</summary>
			
			private long? offset_;
			
			public string GetCouponNo(){
				return this.couponNo_;
			}
			
			public void SetCouponNo(string value){
				this.couponNo_ = value;
			}
			public long? GetOffset(){
				return this.offset_;
			}
			
			public void SetOffset(long? value){
				this.offset_ = value;
			}
			
		}
		
		
		
		
		public class exportCouponGroup_args {
			
			///<summary>
			/// 券批次号
			///</summary>
			
			private string groupNo_;
			
			///<summary>
			/// 偏移量
			///</summary>
			
			private long? offset_;
			
			public string GetGroupNo(){
				return this.groupNo_;
			}
			
			public void SetGroupNo(string value){
				this.groupNo_ = value;
			}
			public long? GetOffset(){
				return this.offset_;
			}
			
			public void SetOffset(long? value){
				this.offset_ = value;
			}
			
		}
		
		
		
		
		public class fetchCommandOrderNos_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.FetchCommandOrderNosRequestModel fetchCommandOrderNosRequestModel_;
			
			public com.vip.pms.data.service.FetchCommandOrderNosRequestModel GetFetchCommandOrderNosRequestModel(){
				return this.fetchCommandOrderNosRequestModel_;
			}
			
			public void SetFetchCommandOrderNosRequestModel(com.vip.pms.data.service.FetchCommandOrderNosRequestModel value){
				this.fetchCommandOrderNosRequestModel_ = value;
			}
			
		}
		
		
		
		
		public class fetchOrder_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.FetchOrderRequestModel fetchOrderRequestModel_;
			
			public com.vip.pms.data.service.FetchOrderRequestModel GetFetchOrderRequestModel(){
				return this.fetchOrderRequestModel_;
			}
			
			public void SetFetchOrderRequestModel(com.vip.pms.data.service.FetchOrderRequestModel value){
				this.fetchOrderRequestModel_ = value;
			}
			
		}
		
		
		
		
		public class flushCouponRuleIndexSync_args {
			
			
		}
		
		
		
		
		public class flushGoodsOriginalPrice_args {
			
			///<summary>
			///</summary>
			
			private List<com.vip.pms.data.service.FlushGoodsOriginalPriceModel> modelList_;
			
			public List<com.vip.pms.data.service.FlushGoodsOriginalPriceModel> GetModelList(){
				return this.modelList_;
			}
			
			public void SetModelList(List<com.vip.pms.data.service.FlushGoodsOriginalPriceModel> value){
				this.modelList_ = value;
			}
			
		}
		
		
		
		
		public class flushGoodsSurprisePrice_args {
			
			///<summary>
			///</summary>
			
			private List<com.vip.pms.data.service.FlushGoodsSurprisePriceModel> modelList_;
			
			public List<com.vip.pms.data.service.FlushGoodsSurprisePriceModel> GetModelList(){
				return this.modelList_;
			}
			
			public void SetModelList(List<com.vip.pms.data.service.FlushGoodsSurprisePriceModel> value){
				this.modelList_ = value;
			}
			
		}
		
		
		
		
		public class getConfig_args {
			
			///<summary>
			///</summary>
			
			private string type_;
			
			///<summary>
			///</summary>
			
			private string key_;
			
			public string GetType(){
				return this.type_;
			}
			
			public void SetType(string value){
				this.type_ = value;
			}
			public string GetKey(){
				return this.key_;
			}
			
			public void SetKey(string value){
				this.key_ = value;
			}
			
		}
		
		
		
		
		public class getTypeConfig_args {
			
			///<summary>
			///</summary>
			
			private string type_;
			
			public string GetType(){
				return this.type_;
			}
			
			public void SetType(string value){
				this.type_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class modifyCacheSwitchStatus_args {
			
			///<summary>
			/// 开关状态
			///</summary>
			
			private com.vip.pms.data.enums.SwitchStatus? switchStatus_;
			
			public com.vip.pms.data.enums.SwitchStatus? GetSwitchStatus(){
				return this.switchStatus_;
			}
			
			public void SetSwitchStatus(com.vip.pms.data.enums.SwitchStatus? value){
				this.switchStatus_ = value;
			}
			
		}
		
		
		
		
		public class modifyCouponTime_args {
			
			///<summary>
			///</summary>
			
			private int? couponId_;
			
			///<summary>
			///</summary>
			
			private long? beginTime_;
			
			///<summary>
			///</summary>
			
			private long? endTime_;
			
			///<summary>
			/// 任务ID
			///</summary>
			
			private string taskId_;
			
			public int? GetCouponId(){
				return this.couponId_;
			}
			
			public void SetCouponId(int? value){
				this.couponId_ = value;
			}
			public long? GetBeginTime(){
				return this.beginTime_;
			}
			
			public void SetBeginTime(long? value){
				this.beginTime_ = value;
			}
			public long? GetEndTime(){
				return this.endTime_;
			}
			
			public void SetEndTime(long? value){
				this.endTime_ = value;
			}
			public string GetTaskId(){
				return this.taskId_;
			}
			
			public void SetTaskId(string value){
				this.taskId_ = value;
			}
			
		}
		
		
		
		
		public class modifyCouponTimeByUserIds_args {
			
			///<summary>
			///</summary>
			
			private int? couponId_;
			
			///<summary>
			///</summary>
			
			private long? beginTime_;
			
			///<summary>
			///</summary>
			
			private long? endTime_;
			
			///<summary>
			///</summary>
			
			private List<string> userIds_;
			
			public int? GetCouponId(){
				return this.couponId_;
			}
			
			public void SetCouponId(int? value){
				this.couponId_ = value;
			}
			public long? GetBeginTime(){
				return this.beginTime_;
			}
			
			public void SetBeginTime(long? value){
				this.beginTime_ = value;
			}
			public long? GetEndTime(){
				return this.endTime_;
			}
			
			public void SetEndTime(long? value){
				this.endTime_ = value;
			}
			public List<string> GetUserIds(){
				return this.userIds_;
			}
			
			public void SetUserIds(List<string> value){
				this.userIds_ = value;
			}
			
		}
		
		
		
		
		public class multiBind_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.coupon.model.CouponMultiBindRequest multiBindRequest_;
			
			public com.vip.pms.data.coupon.model.CouponMultiBindRequest GetMultiBindRequest(){
				return this.multiBindRequest_;
			}
			
			public void SetMultiBindRequest(com.vip.pms.data.coupon.model.CouponMultiBindRequest value){
				this.multiBindRequest_ = value;
			}
			
		}
		
		
		
		
		public class multiBindSyncMode_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.coupon.model.CouponMultiBindRequest multiBindRequest_;
			
			public com.vip.pms.data.coupon.model.CouponMultiBindRequest GetMultiBindRequest(){
				return this.multiBindRequest_;
			}
			
			public void SetMultiBindRequest(com.vip.pms.data.coupon.model.CouponMultiBindRequest value){
				this.multiBindRequest_ = value;
			}
			
		}
		
		
		
		
		public class offlineActivityCallback_args {
			
			///<summary>
			///</summary>
			
			private List<string> actNoList_;
			
			public List<string> GetActNoList(){
				return this.actNoList_;
			}
			
			public void SetActNoList(List<string> value){
				this.actNoList_ = value;
			}
			
		}
		
		
		
		
		public class offlineActivitySync_args {
			
			///<summary>
			///</summary>
			
			private List<string> actNoList_;
			
			///<summary>
			///</summary>
			
			private long? channelId_;
			
			public List<string> GetActNoList(){
				return this.actNoList_;
			}
			
			public void SetActNoList(List<string> value){
				this.actNoList_ = value;
			}
			public long? GetChannelId(){
				return this.channelId_;
			}
			
			public void SetChannelId(long? value){
				this.channelId_ = value;
			}
			
		}
		
		
		
		
		public class offlineCommandSync_args {
			
			///<summary>
			///</summary>
			
			private List<string> commandNoList_;
			
			public List<string> GetCommandNoList(){
				return this.commandNoList_;
			}
			
			public void SetCommandNoList(List<string> value){
				this.commandNoList_ = value;
			}
			
		}
		
		
		
		
		public class offlinePaySync_args {
			
			///<summary>
			///</summary>
			
			private List<string> payNoList_;
			
			public List<string> GetPayNoList(){
				return this.payNoList_;
			}
			
			public void SetPayNoList(List<string> value){
				this.payNoList_ = value;
			}
			
		}
		
		
		
		
		public class offlinePrepayInfoSync_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.DeletePrepayInfoModel requestModel_;
			
			public com.vip.pms.data.service.DeletePrepayInfoModel GetRequestModel(){
				return this.requestModel_;
			}
			
			public void SetRequestModel(com.vip.pms.data.service.DeletePrepayInfoModel value){
				this.requestModel_ = value;
			}
			
		}
		
		
		
		
		public class offlineSpecialSync_args {
			
			///<summary>
			///</summary>
			
			private List<string> specialNoList_;
			
			public List<string> GetSpecialNoList(){
				return this.specialNoList_;
			}
			
			public void SetSpecialNoList(List<string> value){
				this.specialNoList_ = value;
			}
			
		}
		
		
		
		
		public class offlineSurprisePriceActivitySync_args {
			
			///<summary>
			///</summary>
			
			private List<string> actNoList_;
			
			public List<string> GetActNoList(){
				return this.actNoList_;
			}
			
			public void SetActNoList(List<string> value){
				this.actNoList_ = value;
			}
			
		}
		
		
		
		
		public class prepareActivity_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.model.sync.PrepareActivityRequest request_;
			
			public com.vip.pms.data.model.sync.PrepareActivityRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.pms.data.model.sync.PrepareActivityRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class prepareSpecial_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.model.sync.PrepareActivityRequest request_;
			
			public com.vip.pms.data.model.sync.PrepareActivityRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.pms.data.model.sync.PrepareActivityRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class publishRollbackUseCouponMsg_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.RollbackCouponReqModel reqModel_;
			
			public com.vip.pms.data.service.RollbackCouponReqModel GetReqModel(){
				return this.reqModel_;
			}
			
			public void SetReqModel(com.vip.pms.data.service.RollbackCouponReqModel value){
				this.reqModel_ = value;
			}
			
		}
		
		
		
		
		public class pushOfflineActivities_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.ActivityRequestModel activityRequestModel_;
			
			///<summary>
			/// 子活动的状态。key为子活动编号；value为子活动状态，0：下线，2：取消。
			///</summary>
			
			private Dictionary<string, byte?> subActivityStatus_;
			
			public com.vip.pms.data.service.ActivityRequestModel GetActivityRequestModel(){
				return this.activityRequestModel_;
			}
			
			public void SetActivityRequestModel(com.vip.pms.data.service.ActivityRequestModel value){
				this.activityRequestModel_ = value;
			}
			public Dictionary<string, byte?> GetSubActivityStatus(){
				return this.subActivityStatus_;
			}
			
			public void SetSubActivityStatus(Dictionary<string, byte?> value){
				this.subActivityStatus_ = value;
			}
			
		}
		
		
		
		
		public class queryConfirmationNo_args {
			
			///<summary>
			///</summary>
			
			private List<com.vip.pms.data.service.ConfirmationRequest> confirmationRequests_;
			
			public List<com.vip.pms.data.service.ConfirmationRequest> GetConfirmationRequests(){
				return this.confirmationRequests_;
			}
			
			public void SetConfirmationRequests(List<com.vip.pms.data.service.ConfirmationRequest> value){
				this.confirmationRequests_ = value;
			}
			
		}
		
		
		
		
		public class queryCouponInstanceStat_args {
			
			///<summary>
			/// 券批次号
			///</summary>
			
			private List<string> couponNos_;
			
			public List<string> GetCouponNos(){
				return this.couponNos_;
			}
			
			public void SetCouponNos(List<string> value){
				this.couponNos_ = value;
			}
			
		}
		
		
		
		
		public class queryGoodsFavAmount_args {
			
			///<summary>
			///</summary>
			
			private List<com.vip.pms.data.service.OrderCouponRequest> orderCouponRequests_;
			
			public List<com.vip.pms.data.service.OrderCouponRequest> GetOrderCouponRequests(){
				return this.orderCouponRequests_;
			}
			
			public void SetOrderCouponRequests(List<com.vip.pms.data.service.OrderCouponRequest> value){
				this.orderCouponRequests_ = value;
			}
			
		}
		
		
		
		
		public class refreshOrder_args {
			
			///<summary>
			///</summary>
			
			private string orderNo_;
			
			///<summary>
			///</summary>
			
			private string hashValue_;
			
			///<summary>
			///</summary>
			
			private byte? refIdType_;
			
			///<summary>
			///</summary>
			
			private long? userId_;
			
			public string GetOrderNo(){
				return this.orderNo_;
			}
			
			public void SetOrderNo(string value){
				this.orderNo_ = value;
			}
			public string GetHashValue(){
				return this.hashValue_;
			}
			
			public void SetHashValue(string value){
				this.hashValue_ = value;
			}
			public byte? GetRefIdType(){
				return this.refIdType_;
			}
			
			public void SetRefIdType(byte? value){
				this.refIdType_ = value;
			}
			public long? GetUserId(){
				return this.userId_;
			}
			
			public void SetUserId(long? value){
				this.userId_ = value;
			}
			
		}
		
		
		
		
		public class returnCoupon_args {
			
			///<summary>
			///</summary>
			
			private string userId_;
			
			///<summary>
			///</summary>
			
			private List<string> couponSns_;
			
			public string GetUserId(){
				return this.userId_;
			}
			
			public void SetUserId(string value){
				this.userId_ = value;
			}
			public List<string> GetCouponSns(){
				return this.couponSns_;
			}
			
			public void SetCouponSns(List<string> value){
				this.couponSns_ = value;
			}
			
		}
		
		
		
		
		public class saveActPromotionObject_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.model.sync.ActObjectRequest request_;
			
			public com.vip.pms.data.model.sync.ActObjectRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.pms.data.model.sync.ActObjectRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class saveActivity_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.ActivityRequestModel request_;
			
			public com.vip.pms.data.service.ActivityRequestModel GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.pms.data.service.ActivityRequestModel value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class saveSpecial_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.SpecialRequestModel request_;
			
			public com.vip.pms.data.service.SpecialRequestModel GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.pms.data.service.SpecialRequestModel value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class saveSpecialPromotionObject_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.model.sync.SpecialObjectRequest request_;
			
			public com.vip.pms.data.model.sync.SpecialObjectRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.pms.data.model.sync.SpecialObjectRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class submitSMSendingRequest_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.SMSRequestModel smsRequestModel_;
			
			public com.vip.pms.data.service.SMSRequestModel GetSmsRequestModel(){
				return this.smsRequestModel_;
			}
			
			public void SetSmsRequestModel(com.vip.pms.data.service.SMSRequestModel value){
				this.smsRequestModel_ = value;
			}
			
		}
		
		
		
		
		public class syncAllActivityIndex_args {
			
			///<summary>
			///</summary>
			
			private string indexType_;
			
			public string GetIndexType(){
				return this.indexType_;
			}
			
			public void SetIndexType(string value){
				this.indexType_ = value;
			}
			
		}
		
		
		
		
		public class syncAllCacheByCacheType_args {
			
			///<summary>
			///</summary>
			
			private int? cacheType_;
			
			///<summary>
			///</summary>
			
			private int? scope_;
			
			public int? GetCacheType(){
				return this.cacheType_;
			}
			
			public void SetCacheType(int? value){
				this.cacheType_ = value;
			}
			public int? GetScope(){
				return this.scope_;
			}
			
			public void SetScope(int? value){
				this.scope_ = value;
			}
			
		}
		
		
		
		
		public class syncAllGoodsOriginalPrice_args {
			
			
		}
		
		
		
		
		public class syncAllGoodsSurprisePrice_args {
			
			
		}
		
		
		
		
		public class syncBiPush_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.BiPushTypeEnum? biPushType_;
			
			public com.vip.pms.data.service.BiPushTypeEnum? GetBiPushType(){
				return this.biPushType_;
			}
			
			public void SetBiPushType(com.vip.pms.data.service.BiPushTypeEnum? value){
				this.biPushType_ = value;
			}
			
		}
		
		
		
		
		public class syncBlacklistNew_args {
			
			///<summary>
			///</summary>
			
			private List<com.vip.pms.data.service.BlacklistModel> blacklist_;
			
			public List<com.vip.pms.data.service.BlacklistModel> GetBlacklist(){
				return this.blacklist_;
			}
			
			public void SetBlacklist(List<com.vip.pms.data.service.BlacklistModel> value){
				this.blacklist_ = value;
			}
			
		}
		
		
		
		
		public class syncCacheByActivityNosAndCacheType_args {
			
			///<summary>
			///</summary>
			
			private List<string> activityNos_;
			
			///<summary>
			///</summary>
			
			private int? cacheType_;
			
			///<summary>
			///</summary>
			
			private List<int?> scopes_;
			
			public List<string> GetActivityNos(){
				return this.activityNos_;
			}
			
			public void SetActivityNos(List<string> value){
				this.activityNos_ = value;
			}
			public int? GetCacheType(){
				return this.cacheType_;
			}
			
			public void SetCacheType(int? value){
				this.cacheType_ = value;
			}
			public List<int?> GetScopes(){
				return this.scopes_;
			}
			
			public void SetScopes(List<int?> value){
				this.scopes_ = value;
			}
			
		}
		
		
		
		
		public class syncPayBlackList_args {
			
			///<summary>
			/// 黑名单ID集合，不含重复值。
			///</summary>
			
			private List<string> blackIds_;
			
			public List<string> GetBlackIds(){
				return this.blackIds_;
			}
			
			public void SetBlackIds(List<string> value){
				this.blackIds_ = value;
			}
			
		}
		
		
		
		
		public class updateActPromotionObject_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.model.sync.ActObjectUpdateRequest request_;
			
			public com.vip.pms.data.model.sync.ActObjectUpdateRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.pms.data.model.sync.ActObjectUpdateRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class updateActivityBaseInfo_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.ActivityRequestModel request_;
			
			public com.vip.pms.data.service.ActivityRequestModel GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.pms.data.service.ActivityRequestModel value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class updateSpecialBaseInfo_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.SpecialRequestModel request_;
			
			public com.vip.pms.data.service.SpecialRequestModel GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.pms.data.service.SpecialRequestModel value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class updateSpecialPromotionObject_args {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.model.sync.ActObjectUpdateRequest request_;
			
			public com.vip.pms.data.model.sync.ActObjectUpdateRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.pms.data.model.sync.ActObjectUpdateRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class addActivityUserLog_result {
			
			///<summary>
			///</summary>
			
			private bool? success_;
			
			public bool? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(bool? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class addCommandPersonalCode_result {
			
			///<summary>
			///</summary>
			
			private bool? success_;
			
			public bool? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(bool? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class addCommandUserLog_result {
			
			///<summary>
			///</summary>
			
			private bool? success_;
			
			public bool? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(bool? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class addCouponUserLog_result {
			
			///<summary>
			///</summary>
			
			private bool? success_;
			
			public bool? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(bool? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class addOldPmsOrderInfo_result {
			
			///<summary>
			///</summary>
			
			private bool? success_;
			
			public bool? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(bool? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class addOrUpdateActivitySync_result {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.SyncResult success_;
			
			public com.vip.pms.data.service.SyncResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.pms.data.service.SyncResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class addOrUpdateCommandSync_result {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.SyncResult success_;
			
			public com.vip.pms.data.service.SyncResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.pms.data.service.SyncResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class addOrUpdateConfig_result {
			
			///<summary>
			///</summary>
			
			private bool? success_;
			
			public bool? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(bool? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class addOrUpdateCouponGroupSync_result {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.SyncResult success_;
			
			public com.vip.pms.data.service.SyncResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.pms.data.service.SyncResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class addOrUpdateCouponRuleSync_result {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.SyncResult success_;
			
			public com.vip.pms.data.service.SyncResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.pms.data.service.SyncResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class addOrUpdateCouponSync_result {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.SyncResult success_;
			
			public com.vip.pms.data.service.SyncResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.pms.data.service.SyncResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class addOrUpdatePaySync_result {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.SyncResult success_;
			
			public com.vip.pms.data.service.SyncResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.pms.data.service.SyncResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class addOrUpdatePrepayInfoSync_result {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.SyncResult success_;
			
			public com.vip.pms.data.service.SyncResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.pms.data.service.SyncResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class addOrUpdateSpecialSync_result {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.SyncResult success_;
			
			public com.vip.pms.data.service.SyncResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.pms.data.service.SyncResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class addOrUpdateSurprisePriceActivitySync_result {
			
			
		}
		
		
		
		
		public class addPayUserLog_result {
			
			///<summary>
			///</summary>
			
			private bool? success_;
			
			public bool? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(bool? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class addSpecialUserLog_result {
			
			///<summary>
			///</summary>
			
			private bool? success_;
			
			public bool? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(bool? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class batchModifyCouponTime_result {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.SyncResult success_;
			
			public com.vip.pms.data.service.SyncResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.pms.data.service.SyncResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class buildAllActivityIndex_result {
			
			///<summary>
			///</summary>
			
			private bool? success_;
			
			public bool? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(bool? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class cancelActivitySync_result {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.SyncResult success_;
			
			public com.vip.pms.data.service.SyncResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.pms.data.service.SyncResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class cancelCommandSync_result {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.SyncResult success_;
			
			public com.vip.pms.data.service.SyncResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.pms.data.service.SyncResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class cancelOrOfflineCouponGroupSync_result {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.SyncResult success_;
			
			public com.vip.pms.data.service.SyncResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.pms.data.service.SyncResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class cancelOrOfflineCouponRuleSync_result {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.SyncResult success_;
			
			public com.vip.pms.data.service.SyncResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.pms.data.service.SyncResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class cancelOrOfflineCouponSync_result {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.SyncResult success_;
			
			public com.vip.pms.data.service.SyncResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.pms.data.service.SyncResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class cancelOrder_result {
			
			///<summary>
			///</summary>
			
			private bool? success_;
			
			public bool? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(bool? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class cancelPaySync_result {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.SyncResult success_;
			
			public com.vip.pms.data.service.SyncResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.pms.data.service.SyncResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class cancelSpecialSync_result {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.SyncResult success_;
			
			public com.vip.pms.data.service.SyncResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.pms.data.service.SyncResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class cancelSurprisePriceActivitySync_result {
			
			
		}
		
		
		
		
		public class check_result {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.CheckResult success_;
			
			public com.vip.pms.data.service.CheckResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.pms.data.service.CheckResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class couponActivate_result {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.CouponResResult success_;
			
			public com.vip.pms.data.service.CouponResResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.pms.data.service.CouponResResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class couponBind_result {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.CouponResResult success_;
			
			public com.vip.pms.data.service.CouponResResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.pms.data.service.CouponResResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class couponGroupActivate_result {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.CouponResResult success_;
			
			public com.vip.pms.data.service.CouponResResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.pms.data.service.CouponResResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class couponGroupBind_result {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.CouponResResult success_;
			
			public com.vip.pms.data.service.CouponResResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.pms.data.service.CouponResResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class delGoodsOriginalPrice_result {
			
			
		}
		
		
		
		
		public class delGoodsSurprisePrice_result {
			
			
		}
		
		
		
		
		public class deleteConfig_result {
			
			///<summary>
			///</summary>
			
			private bool? success_;
			
			public bool? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(bool? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class deletePrepayInfoByMidSync_result {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.SyncResult success_;
			
			public com.vip.pms.data.service.SyncResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.pms.data.service.SyncResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class deletePrepayInfoSync_result {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.SyncResult success_;
			
			public com.vip.pms.data.service.SyncResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.pms.data.service.SyncResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class exportCoupon_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.pms.data.service.ExportRespModel> success_;
			
			public List<com.vip.pms.data.service.ExportRespModel> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.pms.data.service.ExportRespModel> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class exportCouponGroup_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.pms.data.service.ExportRespModel> success_;
			
			public List<com.vip.pms.data.service.ExportRespModel> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.pms.data.service.ExportRespModel> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class fetchCommandOrderNos_result {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.OrderNosResult success_;
			
			public com.vip.pms.data.service.OrderNosResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.pms.data.service.OrderNosResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class fetchOrder_result {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.OrderResult success_;
			
			public com.vip.pms.data.service.OrderResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.pms.data.service.OrderResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class flushCouponRuleIndexSync_result {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.SyncResult success_;
			
			public com.vip.pms.data.service.SyncResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.pms.data.service.SyncResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class flushGoodsOriginalPrice_result {
			
			
		}
		
		
		
		
		public class flushGoodsSurprisePrice_result {
			
			
		}
		
		
		
		
		public class getConfig_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.pms.data.service.AdminConfigModel> success_;
			
			public List<com.vip.pms.data.service.AdminConfigModel> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.pms.data.service.AdminConfigModel> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getTypeConfig_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.pms.data.service.AdminConfigModel> success_;
			
			public List<com.vip.pms.data.service.AdminConfigModel> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.pms.data.service.AdminConfigModel> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_result {
			
			///<summary>
			///</summary>
			
			private com.vip.hermes.core.health.CheckResult success_;
			
			public com.vip.hermes.core.health.CheckResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.hermes.core.health.CheckResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class modifyCacheSwitchStatus_result {
			
			///<summary>
			///</summary>
			
			private bool? success_;
			
			public bool? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(bool? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class modifyCouponTime_result {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.SyncResult success_;
			
			public com.vip.pms.data.service.SyncResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.pms.data.service.SyncResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class modifyCouponTimeByUserIds_result {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.SyncResult success_;
			
			public com.vip.pms.data.service.SyncResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.pms.data.service.SyncResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class multiBind_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.pms.data.coupon.model.CouponMultiBindResponse> success_;
			
			public List<com.vip.pms.data.coupon.model.CouponMultiBindResponse> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.pms.data.coupon.model.CouponMultiBindResponse> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class multiBindSyncMode_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.pms.data.coupon.model.CouponMultiBindResponse> success_;
			
			public List<com.vip.pms.data.coupon.model.CouponMultiBindResponse> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.pms.data.coupon.model.CouponMultiBindResponse> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class offlineActivityCallback_result {
			
			///<summary>
			///</summary>
			
			private bool? success_;
			
			public bool? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(bool? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class offlineActivitySync_result {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.SyncResult success_;
			
			public com.vip.pms.data.service.SyncResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.pms.data.service.SyncResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class offlineCommandSync_result {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.SyncResult success_;
			
			public com.vip.pms.data.service.SyncResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.pms.data.service.SyncResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class offlinePaySync_result {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.SyncResult success_;
			
			public com.vip.pms.data.service.SyncResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.pms.data.service.SyncResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class offlinePrepayInfoSync_result {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.SyncResult success_;
			
			public com.vip.pms.data.service.SyncResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.pms.data.service.SyncResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class offlineSpecialSync_result {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.SyncResult success_;
			
			public com.vip.pms.data.service.SyncResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.pms.data.service.SyncResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class offlineSurprisePriceActivitySync_result {
			
			
		}
		
		
		
		
		public class prepareActivity_result {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.model.sync.PrepareActivityResult success_;
			
			public com.vip.pms.data.model.sync.PrepareActivityResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.pms.data.model.sync.PrepareActivityResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class prepareSpecial_result {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.model.sync.PrepareActivityResult success_;
			
			public com.vip.pms.data.model.sync.PrepareActivityResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.pms.data.model.sync.PrepareActivityResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class publishRollbackUseCouponMsg_result {
			
			///<summary>
			///</summary>
			
			private bool? success_;
			
			public bool? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(bool? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class pushOfflineActivities_result {
			
			///<summary>
			///</summary>
			
			private com.vip.pms.data.service.SyncResult success_;
			
			public com.vip.pms.data.service.SyncResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.pms.data.service.SyncResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class queryConfirmationNo_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.pms.data.service.ConfirmationResult> success_;
			
			public List<com.vip.pms.data.service.ConfirmationResult> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.pms.data.service.ConfirmationResult> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class queryCouponInstanceStat_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.pms.data.service.CouponInstanceStatResponse> success_;
			
			public List<com.vip.pms.data.service.CouponInstanceStatResponse> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.pms.data.service.CouponInstanceStatResponse> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class queryGoodsFavAmount_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.pms.data.service.OrderFavDetailResult> success_;
			
			public List<com.vip.pms.data.service.OrderFavDetailResult> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.pms.data.service.OrderFavDetailResult> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class refreshOrder_result {
			
			///<summary>
			///</summary>
			
			private bool? success_;
			
			public bool? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(bool? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class returnCoupon_result {
			
			///<summary>
			///</summary>
			
			private bool? success_;
			
			public bool? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(bool? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class saveActPromotionObject_result {
			
			
		}
		
		
		
		
		public class saveActivity_result {
			
			
		}
		
		
		
		
		public class saveSpecial_result {
			
			
		}
		
		
		
		
		public class saveSpecialPromotionObject_result {
			
			
		}
		
		
		
		
		public class submitSMSendingRequest_result {
			
			
		}
		
		
		
		
		public class syncAllActivityIndex_result {
			
			///<summary>
			///</summary>
			
			private bool? success_;
			
			public bool? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(bool? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class syncAllCacheByCacheType_result {
			
			///<summary>
			///</summary>
			
			private bool? success_;
			
			public bool? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(bool? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class syncAllGoodsOriginalPrice_result {
			
			
		}
		
		
		
		
		public class syncAllGoodsSurprisePrice_result {
			
			
		}
		
		
		
		
		public class syncBiPush_result {
			
			///<summary>
			///</summary>
			
			private bool? success_;
			
			public bool? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(bool? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class syncBlacklistNew_result {
			
			///<summary>
			///</summary>
			
			private bool? success_;
			
			public bool? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(bool? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class syncCacheByActivityNosAndCacheType_result {
			
			///<summary>
			///</summary>
			
			private bool? success_;
			
			public bool? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(bool? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class syncPayBlackList_result {
			
			///<summary>
			///</summary>
			
			private bool? success_;
			
			public bool? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(bool? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class updateActPromotionObject_result {
			
			
		}
		
		
		
		
		public class updateActivityBaseInfo_result {
			
			
		}
		
		
		
		
		public class updateSpecialBaseInfo_result {
			
			
		}
		
		
		
		
		public class updateSpecialPromotionObject_result {
			
			
		}
		
		
		
		
		
		public class addActivityUserLog_argsHelper : TBeanSerializer<addActivityUserLog_args>
		{
			
			public static addActivityUserLog_argsHelper OBJ = new addActivityUserLog_argsHelper();
			
			public static addActivityUserLog_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addActivityUserLog_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.ActivityUserLogRequestModel value;
					
					value = new com.vip.pms.data.service.ActivityUserLogRequestModel();
					com.vip.pms.data.service.ActivityUserLogRequestModelHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addActivityUserLog_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.pms.data.service.ActivityUserLogRequestModelHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addActivityUserLog_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addCommandPersonalCode_argsHelper : TBeanSerializer<addCommandPersonalCode_args>
		{
			
			public static addCommandPersonalCode_argsHelper OBJ = new addCommandPersonalCode_argsHelper();
			
			public static addCommandPersonalCode_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addCommandPersonalCode_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCommandId(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetPersonalCode(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addCommandPersonalCode_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCommandId() != null) {
					
					oprot.WriteFieldBegin("commandId");
					oprot.WriteString(structs.GetCommandId());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("commandId can not be null!");
				}
				
				
				if(structs.GetPersonalCode() != null) {
					
					oprot.WriteFieldBegin("personalCode");
					oprot.WriteString(structs.GetPersonalCode());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("personalCode can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addCommandPersonalCode_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addCommandUserLog_argsHelper : TBeanSerializer<addCommandUserLog_args>
		{
			
			public static addCommandUserLog_argsHelper OBJ = new addCommandUserLog_argsHelper();
			
			public static addCommandUserLog_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addCommandUserLog_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.CommandUserLogRequestModel value;
					
					value = new com.vip.pms.data.service.CommandUserLogRequestModel();
					com.vip.pms.data.service.CommandUserLogRequestModelHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addCommandUserLog_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.pms.data.service.CommandUserLogRequestModelHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addCommandUserLog_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addCouponUserLog_argsHelper : TBeanSerializer<addCouponUserLog_args>
		{
			
			public static addCouponUserLog_argsHelper OBJ = new addCouponUserLog_argsHelper();
			
			public static addCouponUserLog_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addCouponUserLog_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.CouponOrderRequestModel value;
					
					value = new com.vip.pms.data.service.CouponOrderRequestModel();
					com.vip.pms.data.service.CouponOrderRequestModelHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addCouponUserLog_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.pms.data.service.CouponOrderRequestModelHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addCouponUserLog_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addOldPmsOrderInfo_argsHelper : TBeanSerializer<addOldPmsOrderInfo_args>
		{
			
			public static addOldPmsOrderInfo_argsHelper OBJ = new addOldPmsOrderInfo_argsHelper();
			
			public static addOldPmsOrderInfo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addOldPmsOrderInfo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.OldPmsOrderRequestModel value;
					
					value = new com.vip.pms.data.service.OldPmsOrderRequestModel();
					com.vip.pms.data.service.OldPmsOrderRequestModelHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addOldPmsOrderInfo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.pms.data.service.OldPmsOrderRequestModelHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addOldPmsOrderInfo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addOrUpdateActivitySync_argsHelper : TBeanSerializer<addOrUpdateActivitySync_args>
		{
			
			public static addOrUpdateActivitySync_argsHelper OBJ = new addOrUpdateActivitySync_argsHelper();
			
			public static addOrUpdateActivitySync_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addOrUpdateActivitySync_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.ActivityRequestModel value;
					
					value = new com.vip.pms.data.service.ActivityRequestModel();
					com.vip.pms.data.service.ActivityRequestModelHelper.getInstance().Read(value, iprot);
					
					structs.SetActivityRequestModel(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addOrUpdateActivitySync_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetActivityRequestModel() != null) {
					
					oprot.WriteFieldBegin("activityRequestModel");
					
					com.vip.pms.data.service.ActivityRequestModelHelper.getInstance().Write(structs.GetActivityRequestModel(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("activityRequestModel can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addOrUpdateActivitySync_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addOrUpdateCommandSync_argsHelper : TBeanSerializer<addOrUpdateCommandSync_args>
		{
			
			public static addOrUpdateCommandSync_argsHelper OBJ = new addOrUpdateCommandSync_argsHelper();
			
			public static addOrUpdateCommandSync_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addOrUpdateCommandSync_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.CommandRequestModel value;
					
					value = new com.vip.pms.data.service.CommandRequestModel();
					com.vip.pms.data.service.CommandRequestModelHelper.getInstance().Read(value, iprot);
					
					structs.SetCommandRequestModel(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addOrUpdateCommandSync_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCommandRequestModel() != null) {
					
					oprot.WriteFieldBegin("commandRequestModel");
					
					com.vip.pms.data.service.CommandRequestModelHelper.getInstance().Write(structs.GetCommandRequestModel(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("commandRequestModel can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addOrUpdateCommandSync_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addOrUpdateConfig_argsHelper : TBeanSerializer<addOrUpdateConfig_args>
		{
			
			public static addOrUpdateConfig_argsHelper OBJ = new addOrUpdateConfig_argsHelper();
			
			public static addOrUpdateConfig_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addOrUpdateConfig_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.AdminConfigModel value;
					
					value = new com.vip.pms.data.service.AdminConfigModel();
					com.vip.pms.data.service.AdminConfigModelHelper.getInstance().Read(value, iprot);
					
					structs.SetConfig(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addOrUpdateConfig_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetConfig() != null) {
					
					oprot.WriteFieldBegin("config");
					
					com.vip.pms.data.service.AdminConfigModelHelper.getInstance().Write(structs.GetConfig(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("config can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addOrUpdateConfig_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addOrUpdateCouponGroupSync_argsHelper : TBeanSerializer<addOrUpdateCouponGroupSync_args>
		{
			
			public static addOrUpdateCouponGroupSync_argsHelper OBJ = new addOrUpdateCouponGroupSync_argsHelper();
			
			public static addOrUpdateCouponGroupSync_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addOrUpdateCouponGroupSync_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.CouponRequestModel value;
					
					value = new com.vip.pms.data.service.CouponRequestModel();
					com.vip.pms.data.service.CouponRequestModelHelper.getInstance().Read(value, iprot);
					
					structs.SetCouponRequestModel(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addOrUpdateCouponGroupSync_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCouponRequestModel() != null) {
					
					oprot.WriteFieldBegin("couponRequestModel");
					
					com.vip.pms.data.service.CouponRequestModelHelper.getInstance().Write(structs.GetCouponRequestModel(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("couponRequestModel can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addOrUpdateCouponGroupSync_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addOrUpdateCouponRuleSync_argsHelper : TBeanSerializer<addOrUpdateCouponRuleSync_args>
		{
			
			public static addOrUpdateCouponRuleSync_argsHelper OBJ = new addOrUpdateCouponRuleSync_argsHelper();
			
			public static addOrUpdateCouponRuleSync_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addOrUpdateCouponRuleSync_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.CouponRuleRequestModel value;
					
					value = new com.vip.pms.data.service.CouponRuleRequestModel();
					com.vip.pms.data.service.CouponRuleRequestModelHelper.getInstance().Read(value, iprot);
					
					structs.SetCouponRuleRequestModel(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addOrUpdateCouponRuleSync_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCouponRuleRequestModel() != null) {
					
					oprot.WriteFieldBegin("couponRuleRequestModel");
					
					com.vip.pms.data.service.CouponRuleRequestModelHelper.getInstance().Write(structs.GetCouponRuleRequestModel(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("couponRuleRequestModel can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addOrUpdateCouponRuleSync_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addOrUpdateCouponSync_argsHelper : TBeanSerializer<addOrUpdateCouponSync_args>
		{
			
			public static addOrUpdateCouponSync_argsHelper OBJ = new addOrUpdateCouponSync_argsHelper();
			
			public static addOrUpdateCouponSync_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addOrUpdateCouponSync_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.CouponRequestModel value;
					
					value = new com.vip.pms.data.service.CouponRequestModel();
					com.vip.pms.data.service.CouponRequestModelHelper.getInstance().Read(value, iprot);
					
					structs.SetCouponRequestModel(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addOrUpdateCouponSync_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCouponRequestModel() != null) {
					
					oprot.WriteFieldBegin("couponRequestModel");
					
					com.vip.pms.data.service.CouponRequestModelHelper.getInstance().Write(structs.GetCouponRequestModel(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("couponRequestModel can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addOrUpdateCouponSync_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addOrUpdatePaySync_argsHelper : TBeanSerializer<addOrUpdatePaySync_args>
		{
			
			public static addOrUpdatePaySync_argsHelper OBJ = new addOrUpdatePaySync_argsHelper();
			
			public static addOrUpdatePaySync_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addOrUpdatePaySync_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.PayRequestModel value;
					
					value = new com.vip.pms.data.service.PayRequestModel();
					com.vip.pms.data.service.PayRequestModelHelper.getInstance().Read(value, iprot);
					
					structs.SetPayRequestModel(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addOrUpdatePaySync_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPayRequestModel() != null) {
					
					oprot.WriteFieldBegin("payRequestModel");
					
					com.vip.pms.data.service.PayRequestModelHelper.getInstance().Write(structs.GetPayRequestModel(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("payRequestModel can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addOrUpdatePaySync_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addOrUpdatePrepayInfoSync_argsHelper : TBeanSerializer<addOrUpdatePrepayInfoSync_args>
		{
			
			public static addOrUpdatePrepayInfoSync_argsHelper OBJ = new addOrUpdatePrepayInfoSync_argsHelper();
			
			public static addOrUpdatePrepayInfoSync_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addOrUpdatePrepayInfoSync_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.PrepayInfoRequestModel value;
					
					value = new com.vip.pms.data.service.PrepayInfoRequestModel();
					com.vip.pms.data.service.PrepayInfoRequestModelHelper.getInstance().Read(value, iprot);
					
					structs.SetPrepayInfoRequestModel(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addOrUpdatePrepayInfoSync_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPrepayInfoRequestModel() != null) {
					
					oprot.WriteFieldBegin("prepayInfoRequestModel");
					
					com.vip.pms.data.service.PrepayInfoRequestModelHelper.getInstance().Write(structs.GetPrepayInfoRequestModel(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("prepayInfoRequestModel can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addOrUpdatePrepayInfoSync_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addOrUpdateSpecialSync_argsHelper : TBeanSerializer<addOrUpdateSpecialSync_args>
		{
			
			public static addOrUpdateSpecialSync_argsHelper OBJ = new addOrUpdateSpecialSync_argsHelper();
			
			public static addOrUpdateSpecialSync_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addOrUpdateSpecialSync_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.SpecialRequestModel value;
					
					value = new com.vip.pms.data.service.SpecialRequestModel();
					com.vip.pms.data.service.SpecialRequestModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSpecialRequestModel(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addOrUpdateSpecialSync_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSpecialRequestModel() != null) {
					
					oprot.WriteFieldBegin("specialRequestModel");
					
					com.vip.pms.data.service.SpecialRequestModelHelper.getInstance().Write(structs.GetSpecialRequestModel(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("specialRequestModel can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addOrUpdateSpecialSync_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addOrUpdateSurprisePriceActivitySync_argsHelper : TBeanSerializer<addOrUpdateSurprisePriceActivitySync_args>
		{
			
			public static addOrUpdateSurprisePriceActivitySync_argsHelper OBJ = new addOrUpdateSurprisePriceActivitySync_argsHelper();
			
			public static addOrUpdateSurprisePriceActivitySync_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addOrUpdateSurprisePriceActivitySync_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.SurprisePriceActivityRequestModel value;
					
					value = new com.vip.pms.data.service.SurprisePriceActivityRequestModel();
					com.vip.pms.data.service.SurprisePriceActivityRequestModelHelper.getInstance().Read(value, iprot);
					
					structs.SetActivityRequestModel(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addOrUpdateSurprisePriceActivitySync_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetActivityRequestModel() != null) {
					
					oprot.WriteFieldBegin("activityRequestModel");
					
					com.vip.pms.data.service.SurprisePriceActivityRequestModelHelper.getInstance().Write(structs.GetActivityRequestModel(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("activityRequestModel can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addOrUpdateSurprisePriceActivitySync_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addPayUserLog_argsHelper : TBeanSerializer<addPayUserLog_args>
		{
			
			public static addPayUserLog_argsHelper OBJ = new addPayUserLog_argsHelper();
			
			public static addPayUserLog_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addPayUserLog_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.PayUserLogRequestModel value;
					
					value = new com.vip.pms.data.service.PayUserLogRequestModel();
					com.vip.pms.data.service.PayUserLogRequestModelHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addPayUserLog_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.pms.data.service.PayUserLogRequestModelHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addPayUserLog_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addSpecialUserLog_argsHelper : TBeanSerializer<addSpecialUserLog_args>
		{
			
			public static addSpecialUserLog_argsHelper OBJ = new addSpecialUserLog_argsHelper();
			
			public static addSpecialUserLog_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addSpecialUserLog_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.SpecialUserLogRequestModel value;
					
					value = new com.vip.pms.data.service.SpecialUserLogRequestModel();
					com.vip.pms.data.service.SpecialUserLogRequestModelHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addSpecialUserLog_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.pms.data.service.SpecialUserLogRequestModelHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addSpecialUserLog_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchModifyCouponTime_argsHelper : TBeanSerializer<batchModifyCouponTime_args>
		{
			
			public static batchModifyCouponTime_argsHelper OBJ = new batchModifyCouponTime_argsHelper();
			
			public static batchModifyCouponTime_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchModifyCouponTime_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.pms.data.service.ModifyInfoRequestModel> value;
					
					value = new List<com.vip.pms.data.service.ModifyInfoRequestModel>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.pms.data.service.ModifyInfoRequestModel elem0;
							
							elem0 = new com.vip.pms.data.service.ModifyInfoRequestModel();
							com.vip.pms.data.service.ModifyInfoRequestModelHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetModifyList(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetTaskId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(batchModifyCouponTime_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetModifyList() != null) {
					
					oprot.WriteFieldBegin("modifyList");
					
					oprot.WriteListBegin();
					foreach(com.vip.pms.data.service.ModifyInfoRequestModel _item0 in structs.GetModifyList()){
						
						
						com.vip.pms.data.service.ModifyInfoRequestModelHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("modifyList can not be null!");
				}
				
				
				if(structs.GetTaskId() != null) {
					
					oprot.WriteFieldBegin("taskId");
					oprot.WriteString(structs.GetTaskId());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("taskId can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchModifyCouponTime_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class buildAllActivityIndex_argsHelper : TBeanSerializer<buildAllActivityIndex_args>
		{
			
			public static buildAllActivityIndex_argsHelper OBJ = new buildAllActivityIndex_argsHelper();
			
			public static buildAllActivityIndex_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(buildAllActivityIndex_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetIndexType(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(buildAllActivityIndex_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetIndexType() != null) {
					
					oprot.WriteFieldBegin("indexType");
					oprot.WriteString(structs.GetIndexType());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("indexType can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(buildAllActivityIndex_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class cancelActivitySync_argsHelper : TBeanSerializer<cancelActivitySync_args>
		{
			
			public static cancelActivitySync_argsHelper OBJ = new cancelActivitySync_argsHelper();
			
			public static cancelActivitySync_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(cancelActivitySync_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							string elem0;
							elem0 = iprot.ReadString();
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetActNoList(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetChannelId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(cancelActivitySync_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetActNoList() != null) {
					
					oprot.WriteFieldBegin("actNoList");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetActNoList()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("actNoList can not be null!");
				}
				
				
				if(structs.GetChannelId() != null) {
					
					oprot.WriteFieldBegin("channelId");
					oprot.WriteI64((long)structs.GetChannelId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(cancelActivitySync_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class cancelCommandSync_argsHelper : TBeanSerializer<cancelCommandSync_args>
		{
			
			public static cancelCommandSync_argsHelper OBJ = new cancelCommandSync_argsHelper();
			
			public static cancelCommandSync_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(cancelCommandSync_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							string elem0;
							elem0 = iprot.ReadString();
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetCommandNoList(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(cancelCommandSync_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCommandNoList() != null) {
					
					oprot.WriteFieldBegin("commandNoList");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetCommandNoList()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("commandNoList can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(cancelCommandSync_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class cancelOrOfflineCouponGroupSync_argsHelper : TBeanSerializer<cancelOrOfflineCouponGroupSync_args>
		{
			
			public static cancelOrOfflineCouponGroupSync_argsHelper OBJ = new cancelOrOfflineCouponGroupSync_argsHelper();
			
			public static cancelOrOfflineCouponGroupSync_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(cancelOrOfflineCouponGroupSync_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							string elem1;
							elem1 = iprot.ReadString();
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetNoList(value);
				}
				
				
				
				
				
				if(true){
					
					bool value;
					value = iprot.ReadBool();
					
					structs.SetIsCancel(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(cancelOrOfflineCouponGroupSync_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetNoList() != null) {
					
					oprot.WriteFieldBegin("noList");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetNoList()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("noList can not be null!");
				}
				
				
				if(structs.GetIsCancel() != null) {
					
					oprot.WriteFieldBegin("isCancel");
					oprot.WriteBool((bool)structs.GetIsCancel());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("isCancel can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(cancelOrOfflineCouponGroupSync_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class cancelOrOfflineCouponRuleSync_argsHelper : TBeanSerializer<cancelOrOfflineCouponRuleSync_args>
		{
			
			public static cancelOrOfflineCouponRuleSync_argsHelper OBJ = new cancelOrOfflineCouponRuleSync_argsHelper();
			
			public static cancelOrOfflineCouponRuleSync_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(cancelOrOfflineCouponRuleSync_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							string elem0;
							elem0 = iprot.ReadString();
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetNoList(value);
				}
				
				
				
				
				
				if(true){
					
					bool value;
					value = iprot.ReadBool();
					
					structs.SetIsCancel(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(cancelOrOfflineCouponRuleSync_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetNoList() != null) {
					
					oprot.WriteFieldBegin("noList");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetNoList()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("noList can not be null!");
				}
				
				
				if(structs.GetIsCancel() != null) {
					
					oprot.WriteFieldBegin("isCancel");
					oprot.WriteBool((bool)structs.GetIsCancel());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("isCancel can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(cancelOrOfflineCouponRuleSync_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class cancelOrOfflineCouponSync_argsHelper : TBeanSerializer<cancelOrOfflineCouponSync_args>
		{
			
			public static cancelOrOfflineCouponSync_argsHelper OBJ = new cancelOrOfflineCouponSync_argsHelper();
			
			public static cancelOrOfflineCouponSync_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(cancelOrOfflineCouponSync_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							string elem0;
							elem0 = iprot.ReadString();
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetNoList(value);
				}
				
				
				
				
				
				if(true){
					
					bool value;
					value = iprot.ReadBool();
					
					structs.SetIsCancel(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(cancelOrOfflineCouponSync_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetNoList() != null) {
					
					oprot.WriteFieldBegin("noList");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetNoList()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("noList can not be null!");
				}
				
				
				if(structs.GetIsCancel() != null) {
					
					oprot.WriteFieldBegin("isCancel");
					oprot.WriteBool((bool)structs.GetIsCancel());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("isCancel can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(cancelOrOfflineCouponSync_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class cancelOrder_argsHelper : TBeanSerializer<cancelOrder_args>
		{
			
			public static cancelOrder_argsHelper OBJ = new cancelOrder_argsHelper();
			
			public static cancelOrder_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(cancelOrder_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOrderNo(value);
				}
				
				
				
				
				
				if(true){
					
					byte value;
					value = iprot.ReadByte(); 
					
					structs.SetRefIdType(value);
				}
				
				
				
				
				
				if(true){
					
					List<long?> value;
					
					value = new List<long?>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							long elem0;
							elem0 = iprot.ReadI64(); 
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetRefIdList(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetUserId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(cancelOrder_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetOrderNo() != null) {
					
					oprot.WriteFieldBegin("orderNo");
					oprot.WriteString(structs.GetOrderNo());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("orderNo can not be null!");
				}
				
				
				if(structs.GetRefIdType() != null) {
					
					oprot.WriteFieldBegin("refIdType");
					oprot.WriteByte((byte)structs.GetRefIdType()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("refIdType can not be null!");
				}
				
				
				if(structs.GetRefIdList() != null) {
					
					oprot.WriteFieldBegin("refIdList");
					
					oprot.WriteListBegin();
					foreach(long _item0 in structs.GetRefIdList()){
						
						oprot.WriteI64((long)_item0); 
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetUserId() != null) {
					
					oprot.WriteFieldBegin("userId");
					oprot.WriteI64((long)structs.GetUserId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(cancelOrder_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class cancelPaySync_argsHelper : TBeanSerializer<cancelPaySync_args>
		{
			
			public static cancelPaySync_argsHelper OBJ = new cancelPaySync_argsHelper();
			
			public static cancelPaySync_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(cancelPaySync_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							string elem0;
							elem0 = iprot.ReadString();
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetPayNoList(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(cancelPaySync_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPayNoList() != null) {
					
					oprot.WriteFieldBegin("payNoList");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetPayNoList()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("payNoList can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(cancelPaySync_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class cancelSpecialSync_argsHelper : TBeanSerializer<cancelSpecialSync_args>
		{
			
			public static cancelSpecialSync_argsHelper OBJ = new cancelSpecialSync_argsHelper();
			
			public static cancelSpecialSync_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(cancelSpecialSync_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							string elem1;
							elem1 = iprot.ReadString();
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSpecialNoList(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(cancelSpecialSync_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSpecialNoList() != null) {
					
					oprot.WriteFieldBegin("specialNoList");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetSpecialNoList()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("specialNoList can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(cancelSpecialSync_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class cancelSurprisePriceActivitySync_argsHelper : TBeanSerializer<cancelSurprisePriceActivitySync_args>
		{
			
			public static cancelSurprisePriceActivitySync_argsHelper OBJ = new cancelSurprisePriceActivitySync_argsHelper();
			
			public static cancelSurprisePriceActivitySync_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(cancelSurprisePriceActivitySync_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							string elem1;
							elem1 = iprot.ReadString();
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetActNoList(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(cancelSurprisePriceActivitySync_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetActNoList() != null) {
					
					oprot.WriteFieldBegin("actNoList");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetActNoList()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("actNoList can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(cancelSurprisePriceActivitySync_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class check_argsHelper : TBeanSerializer<check_args>
		{
			
			public static check_argsHelper OBJ = new check_argsHelper();
			
			public static check_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(check_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.CheckRequest value;
					
					value = new com.vip.pms.data.service.CheckRequest();
					com.vip.pms.data.service.CheckRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetCheckRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(check_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCheckRequest() != null) {
					
					oprot.WriteFieldBegin("checkRequest");
					
					com.vip.pms.data.service.CheckRequestHelper.getInstance().Write(structs.GetCheckRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(check_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class couponActivate_argsHelper : TBeanSerializer<couponActivate_args>
		{
			
			public static couponActivate_argsHelper OBJ = new couponActivate_argsHelper();
			
			public static couponActivate_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(couponActivate_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.CouponInstanceModel value;
					
					value = new com.vip.pms.data.service.CouponInstanceModel();
					com.vip.pms.data.service.CouponInstanceModelHelper.getInstance().Read(value, iprot);
					
					structs.SetInstanceModel(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(couponActivate_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetInstanceModel() != null) {
					
					oprot.WriteFieldBegin("instanceModel");
					
					com.vip.pms.data.service.CouponInstanceModelHelper.getInstance().Write(structs.GetInstanceModel(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("instanceModel can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(couponActivate_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class couponBind_argsHelper : TBeanSerializer<couponBind_args>
		{
			
			public static couponBind_argsHelper OBJ = new couponBind_argsHelper();
			
			public static couponBind_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(couponBind_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.CouponInstanceModel value;
					
					value = new com.vip.pms.data.service.CouponInstanceModel();
					com.vip.pms.data.service.CouponInstanceModelHelper.getInstance().Read(value, iprot);
					
					structs.SetInstanceModel(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(couponBind_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetInstanceModel() != null) {
					
					oprot.WriteFieldBegin("instanceModel");
					
					com.vip.pms.data.service.CouponInstanceModelHelper.getInstance().Write(structs.GetInstanceModel(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("instanceModel can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(couponBind_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class couponGroupActivate_argsHelper : TBeanSerializer<couponGroupActivate_args>
		{
			
			public static couponGroupActivate_argsHelper OBJ = new couponGroupActivate_argsHelper();
			
			public static couponGroupActivate_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(couponGroupActivate_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.CouponInstanceModel value;
					
					value = new com.vip.pms.data.service.CouponInstanceModel();
					com.vip.pms.data.service.CouponInstanceModelHelper.getInstance().Read(value, iprot);
					
					structs.SetGroupInstanceModel(value);
				}
				
				
				
				
				
				if(true){
					
					List<com.vip.pms.data.service.CouponInstanceModel> value;
					
					value = new List<com.vip.pms.data.service.CouponInstanceModel>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.pms.data.service.CouponInstanceModel elem1;
							
							elem1 = new com.vip.pms.data.service.CouponInstanceModel();
							com.vip.pms.data.service.CouponInstanceModelHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetCouponInstanceList(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(couponGroupActivate_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetGroupInstanceModel() != null) {
					
					oprot.WriteFieldBegin("groupInstanceModel");
					
					com.vip.pms.data.service.CouponInstanceModelHelper.getInstance().Write(structs.GetGroupInstanceModel(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("groupInstanceModel can not be null!");
				}
				
				
				if(structs.GetCouponInstanceList() != null) {
					
					oprot.WriteFieldBegin("couponInstanceList");
					
					oprot.WriteListBegin();
					foreach(com.vip.pms.data.service.CouponInstanceModel _item0 in structs.GetCouponInstanceList()){
						
						
						com.vip.pms.data.service.CouponInstanceModelHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("couponInstanceList can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(couponGroupActivate_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class couponGroupBind_argsHelper : TBeanSerializer<couponGroupBind_args>
		{
			
			public static couponGroupBind_argsHelper OBJ = new couponGroupBind_argsHelper();
			
			public static couponGroupBind_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(couponGroupBind_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.CouponInstanceModel value;
					
					value = new com.vip.pms.data.service.CouponInstanceModel();
					com.vip.pms.data.service.CouponInstanceModelHelper.getInstance().Read(value, iprot);
					
					structs.SetGroupInstanceModel(value);
				}
				
				
				
				
				
				if(true){
					
					List<com.vip.pms.data.service.CouponInstanceModel> value;
					
					value = new List<com.vip.pms.data.service.CouponInstanceModel>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.pms.data.service.CouponInstanceModel elem2;
							
							elem2 = new com.vip.pms.data.service.CouponInstanceModel();
							com.vip.pms.data.service.CouponInstanceModelHelper.getInstance().Read(elem2, iprot);
							
							value.Add(elem2);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetCouponInstanceList(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(couponGroupBind_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetGroupInstanceModel() != null) {
					
					oprot.WriteFieldBegin("groupInstanceModel");
					
					com.vip.pms.data.service.CouponInstanceModelHelper.getInstance().Write(structs.GetGroupInstanceModel(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("groupInstanceModel can not be null!");
				}
				
				
				if(structs.GetCouponInstanceList() != null) {
					
					oprot.WriteFieldBegin("couponInstanceList");
					
					oprot.WriteListBegin();
					foreach(com.vip.pms.data.service.CouponInstanceModel _item0 in structs.GetCouponInstanceList()){
						
						
						com.vip.pms.data.service.CouponInstanceModelHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("couponInstanceList can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(couponGroupBind_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class delGoodsOriginalPrice_argsHelper : TBeanSerializer<delGoodsOriginalPrice_args>
		{
			
			public static delGoodsOriginalPrice_argsHelper OBJ = new delGoodsOriginalPrice_argsHelper();
			
			public static delGoodsOriginalPrice_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(delGoodsOriginalPrice_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							string elem1;
							elem1 = iprot.ReadString();
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSpuIdList(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(delGoodsOriginalPrice_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSpuIdList() != null) {
					
					oprot.WriteFieldBegin("spuIdList");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetSpuIdList()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("spuIdList can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(delGoodsOriginalPrice_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class delGoodsSurprisePrice_argsHelper : TBeanSerializer<delGoodsSurprisePrice_args>
		{
			
			public static delGoodsSurprisePrice_argsHelper OBJ = new delGoodsSurprisePrice_argsHelper();
			
			public static delGoodsSurprisePrice_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(delGoodsSurprisePrice_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.pms.data.service.FlushGoodsSurprisePriceModel> value;
					
					value = new List<com.vip.pms.data.service.FlushGoodsSurprisePriceModel>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.pms.data.service.FlushGoodsSurprisePriceModel elem1;
							
							elem1 = new com.vip.pms.data.service.FlushGoodsSurprisePriceModel();
							com.vip.pms.data.service.FlushGoodsSurprisePriceModelHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetModelList(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(delGoodsSurprisePrice_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetModelList() != null) {
					
					oprot.WriteFieldBegin("modelList");
					
					oprot.WriteListBegin();
					foreach(com.vip.pms.data.service.FlushGoodsSurprisePriceModel _item0 in structs.GetModelList()){
						
						
						com.vip.pms.data.service.FlushGoodsSurprisePriceModelHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("modelList can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(delGoodsSurprisePrice_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class deleteConfig_argsHelper : TBeanSerializer<deleteConfig_args>
		{
			
			public static deleteConfig_argsHelper OBJ = new deleteConfig_argsHelper();
			
			public static deleteConfig_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(deleteConfig_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetType(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetKey(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(deleteConfig_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetType() != null) {
					
					oprot.WriteFieldBegin("type");
					oprot.WriteString(structs.GetType());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("type can not be null!");
				}
				
				
				if(structs.GetKey() != null) {
					
					oprot.WriteFieldBegin("key");
					oprot.WriteString(structs.GetKey());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("key can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(deleteConfig_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class deletePrepayInfoByMidSync_argsHelper : TBeanSerializer<deletePrepayInfoByMidSync_args>
		{
			
			public static deletePrepayInfoByMidSync_argsHelper OBJ = new deletePrepayInfoByMidSync_argsHelper();
			
			public static deletePrepayInfoByMidSync_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(deletePrepayInfoByMidSync_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetPrepayMainNo(value);
				}
				
				
				
				
				
				if(true){
					
					List<long?> value;
					
					value = new List<long?>();
					iprot.ReadSetBegin();
					while(true){
						
						try{
							
							long elem0;
							elem0 = iprot.ReadI64(); 
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadSetEnd();
					
					structs.SetMerchandiseNos(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(deletePrepayInfoByMidSync_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPrepayMainNo() != null) {
					
					oprot.WriteFieldBegin("prepayMainNo");
					oprot.WriteString(structs.GetPrepayMainNo());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetMerchandiseNos() != null) {
					
					oprot.WriteFieldBegin("merchandiseNos");
					
					oprot.WriteSetBegin();
					foreach(long _item0 in structs.GetMerchandiseNos()){
						
						oprot.WriteI64((long)_item0); 
						
					}
					
					oprot.WriteSetEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(deletePrepayInfoByMidSync_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class deletePrepayInfoSync_argsHelper : TBeanSerializer<deletePrepayInfoSync_args>
		{
			
			public static deletePrepayInfoSync_argsHelper OBJ = new deletePrepayInfoSync_argsHelper();
			
			public static deletePrepayInfoSync_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(deletePrepayInfoSync_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadSetBegin();
					while(true){
						
						try{
							
							string elem1;
							elem1 = iprot.ReadString();
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadSetEnd();
					
					structs.SetPrepayMainNos(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(deletePrepayInfoSync_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPrepayMainNos() != null) {
					
					oprot.WriteFieldBegin("prepayMainNos");
					
					oprot.WriteSetBegin();
					foreach(string _item0 in structs.GetPrepayMainNos()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteSetEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("prepayMainNos can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(deletePrepayInfoSync_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class exportCoupon_argsHelper : TBeanSerializer<exportCoupon_args>
		{
			
			public static exportCoupon_argsHelper OBJ = new exportCoupon_argsHelper();
			
			public static exportCoupon_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(exportCoupon_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCouponNo(value);
				}
				
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetOffset(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(exportCoupon_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCouponNo() != null) {
					
					oprot.WriteFieldBegin("couponNo");
					oprot.WriteString(structs.GetCouponNo());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("couponNo can not be null!");
				}
				
				
				if(structs.GetOffset() != null) {
					
					oprot.WriteFieldBegin("offset");
					oprot.WriteI64((long)structs.GetOffset()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("offset can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(exportCoupon_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class exportCouponGroup_argsHelper : TBeanSerializer<exportCouponGroup_args>
		{
			
			public static exportCouponGroup_argsHelper OBJ = new exportCouponGroup_argsHelper();
			
			public static exportCouponGroup_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(exportCouponGroup_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetGroupNo(value);
				}
				
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetOffset(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(exportCouponGroup_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetGroupNo() != null) {
					
					oprot.WriteFieldBegin("groupNo");
					oprot.WriteString(structs.GetGroupNo());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("groupNo can not be null!");
				}
				
				
				if(structs.GetOffset() != null) {
					
					oprot.WriteFieldBegin("offset");
					oprot.WriteI64((long)structs.GetOffset()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("offset can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(exportCouponGroup_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class fetchCommandOrderNos_argsHelper : TBeanSerializer<fetchCommandOrderNos_args>
		{
			
			public static fetchCommandOrderNos_argsHelper OBJ = new fetchCommandOrderNos_argsHelper();
			
			public static fetchCommandOrderNos_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(fetchCommandOrderNos_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.FetchCommandOrderNosRequestModel value;
					
					value = new com.vip.pms.data.service.FetchCommandOrderNosRequestModel();
					com.vip.pms.data.service.FetchCommandOrderNosRequestModelHelper.getInstance().Read(value, iprot);
					
					structs.SetFetchCommandOrderNosRequestModel(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(fetchCommandOrderNos_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetFetchCommandOrderNosRequestModel() != null) {
					
					oprot.WriteFieldBegin("fetchCommandOrderNosRequestModel");
					
					com.vip.pms.data.service.FetchCommandOrderNosRequestModelHelper.getInstance().Write(structs.GetFetchCommandOrderNosRequestModel(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("fetchCommandOrderNosRequestModel can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(fetchCommandOrderNos_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class fetchOrder_argsHelper : TBeanSerializer<fetchOrder_args>
		{
			
			public static fetchOrder_argsHelper OBJ = new fetchOrder_argsHelper();
			
			public static fetchOrder_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(fetchOrder_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.FetchOrderRequestModel value;
					
					value = new com.vip.pms.data.service.FetchOrderRequestModel();
					com.vip.pms.data.service.FetchOrderRequestModelHelper.getInstance().Read(value, iprot);
					
					structs.SetFetchOrderRequestModel(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(fetchOrder_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetFetchOrderRequestModel() != null) {
					
					oprot.WriteFieldBegin("fetchOrderRequestModel");
					
					com.vip.pms.data.service.FetchOrderRequestModelHelper.getInstance().Write(structs.GetFetchOrderRequestModel(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("fetchOrderRequestModel can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(fetchOrder_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class flushCouponRuleIndexSync_argsHelper : TBeanSerializer<flushCouponRuleIndexSync_args>
		{
			
			public static flushCouponRuleIndexSync_argsHelper OBJ = new flushCouponRuleIndexSync_argsHelper();
			
			public static flushCouponRuleIndexSync_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(flushCouponRuleIndexSync_args structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(flushCouponRuleIndexSync_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(flushCouponRuleIndexSync_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class flushGoodsOriginalPrice_argsHelper : TBeanSerializer<flushGoodsOriginalPrice_args>
		{
			
			public static flushGoodsOriginalPrice_argsHelper OBJ = new flushGoodsOriginalPrice_argsHelper();
			
			public static flushGoodsOriginalPrice_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(flushGoodsOriginalPrice_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.pms.data.service.FlushGoodsOriginalPriceModel> value;
					
					value = new List<com.vip.pms.data.service.FlushGoodsOriginalPriceModel>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.pms.data.service.FlushGoodsOriginalPriceModel elem0;
							
							elem0 = new com.vip.pms.data.service.FlushGoodsOriginalPriceModel();
							com.vip.pms.data.service.FlushGoodsOriginalPriceModelHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetModelList(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(flushGoodsOriginalPrice_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetModelList() != null) {
					
					oprot.WriteFieldBegin("modelList");
					
					oprot.WriteListBegin();
					foreach(com.vip.pms.data.service.FlushGoodsOriginalPriceModel _item0 in structs.GetModelList()){
						
						
						com.vip.pms.data.service.FlushGoodsOriginalPriceModelHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("modelList can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(flushGoodsOriginalPrice_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class flushGoodsSurprisePrice_argsHelper : TBeanSerializer<flushGoodsSurprisePrice_args>
		{
			
			public static flushGoodsSurprisePrice_argsHelper OBJ = new flushGoodsSurprisePrice_argsHelper();
			
			public static flushGoodsSurprisePrice_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(flushGoodsSurprisePrice_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.pms.data.service.FlushGoodsSurprisePriceModel> value;
					
					value = new List<com.vip.pms.data.service.FlushGoodsSurprisePriceModel>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.pms.data.service.FlushGoodsSurprisePriceModel elem1;
							
							elem1 = new com.vip.pms.data.service.FlushGoodsSurprisePriceModel();
							com.vip.pms.data.service.FlushGoodsSurprisePriceModelHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetModelList(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(flushGoodsSurprisePrice_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetModelList() != null) {
					
					oprot.WriteFieldBegin("modelList");
					
					oprot.WriteListBegin();
					foreach(com.vip.pms.data.service.FlushGoodsSurprisePriceModel _item0 in structs.GetModelList()){
						
						
						com.vip.pms.data.service.FlushGoodsSurprisePriceModelHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("modelList can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(flushGoodsSurprisePrice_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getConfig_argsHelper : TBeanSerializer<getConfig_args>
		{
			
			public static getConfig_argsHelper OBJ = new getConfig_argsHelper();
			
			public static getConfig_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getConfig_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetType(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetKey(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getConfig_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetType() != null) {
					
					oprot.WriteFieldBegin("type");
					oprot.WriteString(structs.GetType());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("type can not be null!");
				}
				
				
				if(structs.GetKey() != null) {
					
					oprot.WriteFieldBegin("key");
					oprot.WriteString(structs.GetKey());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("key can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getConfig_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getTypeConfig_argsHelper : TBeanSerializer<getTypeConfig_args>
		{
			
			public static getTypeConfig_argsHelper OBJ = new getTypeConfig_argsHelper();
			
			public static getTypeConfig_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getTypeConfig_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetType(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getTypeConfig_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetType() != null) {
					
					oprot.WriteFieldBegin("type");
					oprot.WriteString(structs.GetType());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("type can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getTypeConfig_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class healthCheck_argsHelper : TBeanSerializer<healthCheck_args>
		{
			
			public static healthCheck_argsHelper OBJ = new healthCheck_argsHelper();
			
			public static healthCheck_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(healthCheck_args structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(healthCheck_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(healthCheck_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class modifyCacheSwitchStatus_argsHelper : TBeanSerializer<modifyCacheSwitchStatus_args>
		{
			
			public static modifyCacheSwitchStatus_argsHelper OBJ = new modifyCacheSwitchStatus_argsHelper();
			
			public static modifyCacheSwitchStatus_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(modifyCacheSwitchStatus_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.enums.SwitchStatus? value;
					
					value = com.vip.pms.data.enums.SwitchStatusUtil.FindByName(iprot.ReadString());
					
					structs.SetSwitchStatus(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(modifyCacheSwitchStatus_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSwitchStatus() != null) {
					
					oprot.WriteFieldBegin("switchStatus");
					oprot.WriteString(structs.GetSwitchStatus().ToString());  
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("switchStatus can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(modifyCacheSwitchStatus_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class modifyCouponTime_argsHelper : TBeanSerializer<modifyCouponTime_args>
		{
			
			public static modifyCouponTime_argsHelper OBJ = new modifyCouponTime_argsHelper();
			
			public static modifyCouponTime_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(modifyCouponTime_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetCouponId(value);
				}
				
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetBeginTime(value);
				}
				
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetEndTime(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetTaskId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(modifyCouponTime_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCouponId() != null) {
					
					oprot.WriteFieldBegin("couponId");
					oprot.WriteI32((int)structs.GetCouponId()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("couponId can not be null!");
				}
				
				
				if(structs.GetBeginTime() != null) {
					
					oprot.WriteFieldBegin("beginTime");
					oprot.WriteI64((long)structs.GetBeginTime()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("beginTime can not be null!");
				}
				
				
				if(structs.GetEndTime() != null) {
					
					oprot.WriteFieldBegin("endTime");
					oprot.WriteI64((long)structs.GetEndTime()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("endTime can not be null!");
				}
				
				
				if(structs.GetTaskId() != null) {
					
					oprot.WriteFieldBegin("taskId");
					oprot.WriteString(structs.GetTaskId());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("taskId can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(modifyCouponTime_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class modifyCouponTimeByUserIds_argsHelper : TBeanSerializer<modifyCouponTimeByUserIds_args>
		{
			
			public static modifyCouponTimeByUserIds_argsHelper OBJ = new modifyCouponTimeByUserIds_argsHelper();
			
			public static modifyCouponTimeByUserIds_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(modifyCouponTimeByUserIds_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetCouponId(value);
				}
				
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetBeginTime(value);
				}
				
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetEndTime(value);
				}
				
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							string elem0;
							elem0 = iprot.ReadString();
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetUserIds(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(modifyCouponTimeByUserIds_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCouponId() != null) {
					
					oprot.WriteFieldBegin("couponId");
					oprot.WriteI32((int)structs.GetCouponId()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("couponId can not be null!");
				}
				
				
				if(structs.GetBeginTime() != null) {
					
					oprot.WriteFieldBegin("beginTime");
					oprot.WriteI64((long)structs.GetBeginTime()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("beginTime can not be null!");
				}
				
				
				if(structs.GetEndTime() != null) {
					
					oprot.WriteFieldBegin("endTime");
					oprot.WriteI64((long)structs.GetEndTime()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("endTime can not be null!");
				}
				
				
				if(structs.GetUserIds() != null) {
					
					oprot.WriteFieldBegin("userIds");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetUserIds()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("userIds can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(modifyCouponTimeByUserIds_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class multiBind_argsHelper : TBeanSerializer<multiBind_args>
		{
			
			public static multiBind_argsHelper OBJ = new multiBind_argsHelper();
			
			public static multiBind_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(multiBind_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.coupon.model.CouponMultiBindRequest value;
					
					value = new com.vip.pms.data.coupon.model.CouponMultiBindRequest();
					com.vip.pms.data.coupon.model.CouponMultiBindRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetMultiBindRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(multiBind_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetMultiBindRequest() != null) {
					
					oprot.WriteFieldBegin("multiBindRequest");
					
					com.vip.pms.data.coupon.model.CouponMultiBindRequestHelper.getInstance().Write(structs.GetMultiBindRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("multiBindRequest can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(multiBind_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class multiBindSyncMode_argsHelper : TBeanSerializer<multiBindSyncMode_args>
		{
			
			public static multiBindSyncMode_argsHelper OBJ = new multiBindSyncMode_argsHelper();
			
			public static multiBindSyncMode_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(multiBindSyncMode_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.coupon.model.CouponMultiBindRequest value;
					
					value = new com.vip.pms.data.coupon.model.CouponMultiBindRequest();
					com.vip.pms.data.coupon.model.CouponMultiBindRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetMultiBindRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(multiBindSyncMode_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetMultiBindRequest() != null) {
					
					oprot.WriteFieldBegin("multiBindRequest");
					
					com.vip.pms.data.coupon.model.CouponMultiBindRequestHelper.getInstance().Write(structs.GetMultiBindRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("multiBindRequest can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(multiBindSyncMode_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class offlineActivityCallback_argsHelper : TBeanSerializer<offlineActivityCallback_args>
		{
			
			public static offlineActivityCallback_argsHelper OBJ = new offlineActivityCallback_argsHelper();
			
			public static offlineActivityCallback_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(offlineActivityCallback_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							string elem0;
							elem0 = iprot.ReadString();
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetActNoList(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(offlineActivityCallback_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetActNoList() != null) {
					
					oprot.WriteFieldBegin("actNoList");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetActNoList()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("actNoList can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(offlineActivityCallback_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class offlineActivitySync_argsHelper : TBeanSerializer<offlineActivitySync_args>
		{
			
			public static offlineActivitySync_argsHelper OBJ = new offlineActivitySync_argsHelper();
			
			public static offlineActivitySync_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(offlineActivitySync_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							string elem1;
							elem1 = iprot.ReadString();
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetActNoList(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetChannelId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(offlineActivitySync_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetActNoList() != null) {
					
					oprot.WriteFieldBegin("actNoList");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetActNoList()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("actNoList can not be null!");
				}
				
				
				if(structs.GetChannelId() != null) {
					
					oprot.WriteFieldBegin("channelId");
					oprot.WriteI64((long)structs.GetChannelId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(offlineActivitySync_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class offlineCommandSync_argsHelper : TBeanSerializer<offlineCommandSync_args>
		{
			
			public static offlineCommandSync_argsHelper OBJ = new offlineCommandSync_argsHelper();
			
			public static offlineCommandSync_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(offlineCommandSync_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							string elem0;
							elem0 = iprot.ReadString();
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetCommandNoList(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(offlineCommandSync_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCommandNoList() != null) {
					
					oprot.WriteFieldBegin("commandNoList");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetCommandNoList()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("commandNoList can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(offlineCommandSync_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class offlinePaySync_argsHelper : TBeanSerializer<offlinePaySync_args>
		{
			
			public static offlinePaySync_argsHelper OBJ = new offlinePaySync_argsHelper();
			
			public static offlinePaySync_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(offlinePaySync_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							string elem1;
							elem1 = iprot.ReadString();
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetPayNoList(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(offlinePaySync_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPayNoList() != null) {
					
					oprot.WriteFieldBegin("payNoList");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetPayNoList()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("payNoList can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(offlinePaySync_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class offlinePrepayInfoSync_argsHelper : TBeanSerializer<offlinePrepayInfoSync_args>
		{
			
			public static offlinePrepayInfoSync_argsHelper OBJ = new offlinePrepayInfoSync_argsHelper();
			
			public static offlinePrepayInfoSync_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(offlinePrepayInfoSync_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.DeletePrepayInfoModel value;
					
					value = new com.vip.pms.data.service.DeletePrepayInfoModel();
					com.vip.pms.data.service.DeletePrepayInfoModelHelper.getInstance().Read(value, iprot);
					
					structs.SetRequestModel(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(offlinePrepayInfoSync_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequestModel() != null) {
					
					oprot.WriteFieldBegin("requestModel");
					
					com.vip.pms.data.service.DeletePrepayInfoModelHelper.getInstance().Write(structs.GetRequestModel(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("requestModel can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(offlinePrepayInfoSync_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class offlineSpecialSync_argsHelper : TBeanSerializer<offlineSpecialSync_args>
		{
			
			public static offlineSpecialSync_argsHelper OBJ = new offlineSpecialSync_argsHelper();
			
			public static offlineSpecialSync_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(offlineSpecialSync_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							string elem0;
							elem0 = iprot.ReadString();
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSpecialNoList(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(offlineSpecialSync_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSpecialNoList() != null) {
					
					oprot.WriteFieldBegin("specialNoList");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetSpecialNoList()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("specialNoList can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(offlineSpecialSync_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class offlineSurprisePriceActivitySync_argsHelper : TBeanSerializer<offlineSurprisePriceActivitySync_args>
		{
			
			public static offlineSurprisePriceActivitySync_argsHelper OBJ = new offlineSurprisePriceActivitySync_argsHelper();
			
			public static offlineSurprisePriceActivitySync_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(offlineSurprisePriceActivitySync_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							string elem1;
							elem1 = iprot.ReadString();
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetActNoList(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(offlineSurprisePriceActivitySync_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetActNoList() != null) {
					
					oprot.WriteFieldBegin("actNoList");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetActNoList()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("actNoList can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(offlineSurprisePriceActivitySync_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class prepareActivity_argsHelper : TBeanSerializer<prepareActivity_args>
		{
			
			public static prepareActivity_argsHelper OBJ = new prepareActivity_argsHelper();
			
			public static prepareActivity_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(prepareActivity_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.model.sync.PrepareActivityRequest value;
					
					value = new com.vip.pms.data.model.sync.PrepareActivityRequest();
					com.vip.pms.data.model.sync.PrepareActivityRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(prepareActivity_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.pms.data.model.sync.PrepareActivityRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(prepareActivity_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class prepareSpecial_argsHelper : TBeanSerializer<prepareSpecial_args>
		{
			
			public static prepareSpecial_argsHelper OBJ = new prepareSpecial_argsHelper();
			
			public static prepareSpecial_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(prepareSpecial_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.model.sync.PrepareActivityRequest value;
					
					value = new com.vip.pms.data.model.sync.PrepareActivityRequest();
					com.vip.pms.data.model.sync.PrepareActivityRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(prepareSpecial_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.pms.data.model.sync.PrepareActivityRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(prepareSpecial_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class publishRollbackUseCouponMsg_argsHelper : TBeanSerializer<publishRollbackUseCouponMsg_args>
		{
			
			public static publishRollbackUseCouponMsg_argsHelper OBJ = new publishRollbackUseCouponMsg_argsHelper();
			
			public static publishRollbackUseCouponMsg_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(publishRollbackUseCouponMsg_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.RollbackCouponReqModel value;
					
					value = new com.vip.pms.data.service.RollbackCouponReqModel();
					com.vip.pms.data.service.RollbackCouponReqModelHelper.getInstance().Read(value, iprot);
					
					structs.SetReqModel(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(publishRollbackUseCouponMsg_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReqModel() != null) {
					
					oprot.WriteFieldBegin("reqModel");
					
					com.vip.pms.data.service.RollbackCouponReqModelHelper.getInstance().Write(structs.GetReqModel(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(publishRollbackUseCouponMsg_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class pushOfflineActivities_argsHelper : TBeanSerializer<pushOfflineActivities_args>
		{
			
			public static pushOfflineActivities_argsHelper OBJ = new pushOfflineActivities_argsHelper();
			
			public static pushOfflineActivities_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(pushOfflineActivities_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.ActivityRequestModel value;
					
					value = new com.vip.pms.data.service.ActivityRequestModel();
					com.vip.pms.data.service.ActivityRequestModelHelper.getInstance().Read(value, iprot);
					
					structs.SetActivityRequestModel(value);
				}
				
				
				
				
				
				if(true){
					
					Dictionary<string, byte?> value;
					
					value = new Dictionary<string, byte?>();
					iprot.ReadMapBegin();
					while(true){
						
						try{
							
							string _key1;
							byte _val1;
							_key1 = iprot.ReadString();
							
							_val1 = iprot.ReadByte(); 
							
							value.Add(_key1, _val1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadMapEnd();
					
					structs.SetSubActivityStatus(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(pushOfflineActivities_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetActivityRequestModel() != null) {
					
					oprot.WriteFieldBegin("activityRequestModel");
					
					com.vip.pms.data.service.ActivityRequestModelHelper.getInstance().Write(structs.GetActivityRequestModel(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("activityRequestModel can not be null!");
				}
				
				
				if(structs.GetSubActivityStatus() != null) {
					
					oprot.WriteFieldBegin("subActivityStatus");
					
					oprot.WriteMapBegin();
					foreach(KeyValuePair< string, byte? > _ir0 in structs.GetSubActivityStatus()){
						
						string _key0 = _ir0.Key;
						byte? _value0 = _ir0.Value;
						oprot.WriteString(_key0);
						
						oprot.WriteByte((byte)_value0); 
						
					}
					
					oprot.WriteMapEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("subActivityStatus can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(pushOfflineActivities_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryConfirmationNo_argsHelper : TBeanSerializer<queryConfirmationNo_args>
		{
			
			public static queryConfirmationNo_argsHelper OBJ = new queryConfirmationNo_argsHelper();
			
			public static queryConfirmationNo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryConfirmationNo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.pms.data.service.ConfirmationRequest> value;
					
					value = new List<com.vip.pms.data.service.ConfirmationRequest>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.pms.data.service.ConfirmationRequest elem1;
							
							elem1 = new com.vip.pms.data.service.ConfirmationRequest();
							com.vip.pms.data.service.ConfirmationRequestHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetConfirmationRequests(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryConfirmationNo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetConfirmationRequests() != null) {
					
					oprot.WriteFieldBegin("confirmationRequests");
					
					oprot.WriteListBegin();
					foreach(com.vip.pms.data.service.ConfirmationRequest _item0 in structs.GetConfirmationRequests()){
						
						
						com.vip.pms.data.service.ConfirmationRequestHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("confirmationRequests can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryConfirmationNo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryCouponInstanceStat_argsHelper : TBeanSerializer<queryCouponInstanceStat_args>
		{
			
			public static queryCouponInstanceStat_argsHelper OBJ = new queryCouponInstanceStat_argsHelper();
			
			public static queryCouponInstanceStat_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryCouponInstanceStat_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadSetBegin();
					while(true){
						
						try{
							
							string elem1;
							elem1 = iprot.ReadString();
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadSetEnd();
					
					structs.SetCouponNos(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryCouponInstanceStat_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCouponNos() != null) {
					
					oprot.WriteFieldBegin("couponNos");
					
					oprot.WriteSetBegin();
					foreach(string _item0 in structs.GetCouponNos()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteSetEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("couponNos can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryCouponInstanceStat_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryGoodsFavAmount_argsHelper : TBeanSerializer<queryGoodsFavAmount_args>
		{
			
			public static queryGoodsFavAmount_argsHelper OBJ = new queryGoodsFavAmount_argsHelper();
			
			public static queryGoodsFavAmount_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryGoodsFavAmount_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.pms.data.service.OrderCouponRequest> value;
					
					value = new List<com.vip.pms.data.service.OrderCouponRequest>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.pms.data.service.OrderCouponRequest elem1;
							
							elem1 = new com.vip.pms.data.service.OrderCouponRequest();
							com.vip.pms.data.service.OrderCouponRequestHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetOrderCouponRequests(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryGoodsFavAmount_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetOrderCouponRequests() != null) {
					
					oprot.WriteFieldBegin("orderCouponRequests");
					
					oprot.WriteListBegin();
					foreach(com.vip.pms.data.service.OrderCouponRequest _item0 in structs.GetOrderCouponRequests()){
						
						
						com.vip.pms.data.service.OrderCouponRequestHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("orderCouponRequests can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryGoodsFavAmount_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class refreshOrder_argsHelper : TBeanSerializer<refreshOrder_args>
		{
			
			public static refreshOrder_argsHelper OBJ = new refreshOrder_argsHelper();
			
			public static refreshOrder_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(refreshOrder_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOrderNo(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetHashValue(value);
				}
				
				
				
				
				
				if(true){
					
					byte value;
					value = iprot.ReadByte(); 
					
					structs.SetRefIdType(value);
				}
				
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetUserId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(refreshOrder_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetOrderNo() != null) {
					
					oprot.WriteFieldBegin("orderNo");
					oprot.WriteString(structs.GetOrderNo());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("orderNo can not be null!");
				}
				
				
				if(structs.GetHashValue() != null) {
					
					oprot.WriteFieldBegin("hashValue");
					oprot.WriteString(structs.GetHashValue());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("hashValue can not be null!");
				}
				
				
				if(structs.GetRefIdType() != null) {
					
					oprot.WriteFieldBegin("refIdType");
					oprot.WriteByte((byte)structs.GetRefIdType()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("refIdType can not be null!");
				}
				
				
				if(structs.GetUserId() != null) {
					
					oprot.WriteFieldBegin("userId");
					oprot.WriteI64((long)structs.GetUserId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(refreshOrder_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class returnCoupon_argsHelper : TBeanSerializer<returnCoupon_args>
		{
			
			public static returnCoupon_argsHelper OBJ = new returnCoupon_argsHelper();
			
			public static returnCoupon_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(returnCoupon_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetUserId(value);
				}
				
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadSetBegin();
					while(true){
						
						try{
							
							string elem0;
							elem0 = iprot.ReadString();
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadSetEnd();
					
					structs.SetCouponSns(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(returnCoupon_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetUserId() != null) {
					
					oprot.WriteFieldBegin("userId");
					oprot.WriteString(structs.GetUserId());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetCouponSns() != null) {
					
					oprot.WriteFieldBegin("couponSns");
					
					oprot.WriteSetBegin();
					foreach(string _item0 in structs.GetCouponSns()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteSetEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(returnCoupon_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class saveActPromotionObject_argsHelper : TBeanSerializer<saveActPromotionObject_args>
		{
			
			public static saveActPromotionObject_argsHelper OBJ = new saveActPromotionObject_argsHelper();
			
			public static saveActPromotionObject_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(saveActPromotionObject_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.model.sync.ActObjectRequest value;
					
					value = new com.vip.pms.data.model.sync.ActObjectRequest();
					com.vip.pms.data.model.sync.ActObjectRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(saveActPromotionObject_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.pms.data.model.sync.ActObjectRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(saveActPromotionObject_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class saveActivity_argsHelper : TBeanSerializer<saveActivity_args>
		{
			
			public static saveActivity_argsHelper OBJ = new saveActivity_argsHelper();
			
			public static saveActivity_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(saveActivity_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.ActivityRequestModel value;
					
					value = new com.vip.pms.data.service.ActivityRequestModel();
					com.vip.pms.data.service.ActivityRequestModelHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(saveActivity_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.pms.data.service.ActivityRequestModelHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(saveActivity_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class saveSpecial_argsHelper : TBeanSerializer<saveSpecial_args>
		{
			
			public static saveSpecial_argsHelper OBJ = new saveSpecial_argsHelper();
			
			public static saveSpecial_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(saveSpecial_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.SpecialRequestModel value;
					
					value = new com.vip.pms.data.service.SpecialRequestModel();
					com.vip.pms.data.service.SpecialRequestModelHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(saveSpecial_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.pms.data.service.SpecialRequestModelHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(saveSpecial_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class saveSpecialPromotionObject_argsHelper : TBeanSerializer<saveSpecialPromotionObject_args>
		{
			
			public static saveSpecialPromotionObject_argsHelper OBJ = new saveSpecialPromotionObject_argsHelper();
			
			public static saveSpecialPromotionObject_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(saveSpecialPromotionObject_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.model.sync.SpecialObjectRequest value;
					
					value = new com.vip.pms.data.model.sync.SpecialObjectRequest();
					com.vip.pms.data.model.sync.SpecialObjectRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(saveSpecialPromotionObject_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.pms.data.model.sync.SpecialObjectRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(saveSpecialPromotionObject_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class submitSMSendingRequest_argsHelper : TBeanSerializer<submitSMSendingRequest_args>
		{
			
			public static submitSMSendingRequest_argsHelper OBJ = new submitSMSendingRequest_argsHelper();
			
			public static submitSMSendingRequest_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(submitSMSendingRequest_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.SMSRequestModel value;
					
					value = new com.vip.pms.data.service.SMSRequestModel();
					com.vip.pms.data.service.SMSRequestModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSmsRequestModel(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(submitSMSendingRequest_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSmsRequestModel() != null) {
					
					oprot.WriteFieldBegin("smsRequestModel");
					
					com.vip.pms.data.service.SMSRequestModelHelper.getInstance().Write(structs.GetSmsRequestModel(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("smsRequestModel can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(submitSMSendingRequest_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class syncAllActivityIndex_argsHelper : TBeanSerializer<syncAllActivityIndex_args>
		{
			
			public static syncAllActivityIndex_argsHelper OBJ = new syncAllActivityIndex_argsHelper();
			
			public static syncAllActivityIndex_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(syncAllActivityIndex_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetIndexType(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(syncAllActivityIndex_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetIndexType() != null) {
					
					oprot.WriteFieldBegin("indexType");
					oprot.WriteString(structs.GetIndexType());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("indexType can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(syncAllActivityIndex_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class syncAllCacheByCacheType_argsHelper : TBeanSerializer<syncAllCacheByCacheType_args>
		{
			
			public static syncAllCacheByCacheType_argsHelper OBJ = new syncAllCacheByCacheType_argsHelper();
			
			public static syncAllCacheByCacheType_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(syncAllCacheByCacheType_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetCacheType(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetScope(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(syncAllCacheByCacheType_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCacheType() != null) {
					
					oprot.WriteFieldBegin("cacheType");
					oprot.WriteI32((int)structs.GetCacheType()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetScope() != null) {
					
					oprot.WriteFieldBegin("scope");
					oprot.WriteI32((int)structs.GetScope()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(syncAllCacheByCacheType_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class syncAllGoodsOriginalPrice_argsHelper : TBeanSerializer<syncAllGoodsOriginalPrice_args>
		{
			
			public static syncAllGoodsOriginalPrice_argsHelper OBJ = new syncAllGoodsOriginalPrice_argsHelper();
			
			public static syncAllGoodsOriginalPrice_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(syncAllGoodsOriginalPrice_args structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(syncAllGoodsOriginalPrice_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(syncAllGoodsOriginalPrice_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class syncAllGoodsSurprisePrice_argsHelper : TBeanSerializer<syncAllGoodsSurprisePrice_args>
		{
			
			public static syncAllGoodsSurprisePrice_argsHelper OBJ = new syncAllGoodsSurprisePrice_argsHelper();
			
			public static syncAllGoodsSurprisePrice_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(syncAllGoodsSurprisePrice_args structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(syncAllGoodsSurprisePrice_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(syncAllGoodsSurprisePrice_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class syncBiPush_argsHelper : TBeanSerializer<syncBiPush_args>
		{
			
			public static syncBiPush_argsHelper OBJ = new syncBiPush_argsHelper();
			
			public static syncBiPush_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(syncBiPush_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.BiPushTypeEnum? value;
					
					value = com.vip.pms.data.service.BiPushTypeEnumUtil.FindByName(iprot.ReadString());
					
					structs.SetBiPushType(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(syncBiPush_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetBiPushType() != null) {
					
					oprot.WriteFieldBegin("biPushType");
					oprot.WriteString(structs.GetBiPushType().ToString());  
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(syncBiPush_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class syncBlacklistNew_argsHelper : TBeanSerializer<syncBlacklistNew_args>
		{
			
			public static syncBlacklistNew_argsHelper OBJ = new syncBlacklistNew_argsHelper();
			
			public static syncBlacklistNew_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(syncBlacklistNew_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.pms.data.service.BlacklistModel> value;
					
					value = new List<com.vip.pms.data.service.BlacklistModel>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.pms.data.service.BlacklistModel elem0;
							
							elem0 = new com.vip.pms.data.service.BlacklistModel();
							com.vip.pms.data.service.BlacklistModelHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetBlacklist(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(syncBlacklistNew_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetBlacklist() != null) {
					
					oprot.WriteFieldBegin("blacklist");
					
					oprot.WriteListBegin();
					foreach(com.vip.pms.data.service.BlacklistModel _item0 in structs.GetBlacklist()){
						
						
						com.vip.pms.data.service.BlacklistModelHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("blacklist can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(syncBlacklistNew_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class syncCacheByActivityNosAndCacheType_argsHelper : TBeanSerializer<syncCacheByActivityNosAndCacheType_args>
		{
			
			public static syncCacheByActivityNosAndCacheType_argsHelper OBJ = new syncCacheByActivityNosAndCacheType_argsHelper();
			
			public static syncCacheByActivityNosAndCacheType_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(syncCacheByActivityNosAndCacheType_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							string elem1;
							elem1 = iprot.ReadString();
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetActivityNos(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetCacheType(value);
				}
				
				
				
				
				
				if(true){
					
					List<int?> value;
					
					value = new List<int?>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							int elem2;
							elem2 = iprot.ReadI32(); 
							
							value.Add(elem2);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetScopes(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(syncCacheByActivityNosAndCacheType_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetActivityNos() != null) {
					
					oprot.WriteFieldBegin("activityNos");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetActivityNos()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetCacheType() != null) {
					
					oprot.WriteFieldBegin("cacheType");
					oprot.WriteI32((int)structs.GetCacheType()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetScopes() != null) {
					
					oprot.WriteFieldBegin("scopes");
					
					oprot.WriteListBegin();
					foreach(int _item0 in structs.GetScopes()){
						
						oprot.WriteI32((int)_item0); 
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(syncCacheByActivityNosAndCacheType_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class syncPayBlackList_argsHelper : TBeanSerializer<syncPayBlackList_args>
		{
			
			public static syncPayBlackList_argsHelper OBJ = new syncPayBlackList_argsHelper();
			
			public static syncPayBlackList_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(syncPayBlackList_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadSetBegin();
					while(true){
						
						try{
							
							string elem1;
							elem1 = iprot.ReadString();
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadSetEnd();
					
					structs.SetBlackIds(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(syncPayBlackList_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetBlackIds() != null) {
					
					oprot.WriteFieldBegin("blackIds");
					
					oprot.WriteSetBegin();
					foreach(string _item0 in structs.GetBlackIds()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteSetEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("blackIds can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(syncPayBlackList_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateActPromotionObject_argsHelper : TBeanSerializer<updateActPromotionObject_args>
		{
			
			public static updateActPromotionObject_argsHelper OBJ = new updateActPromotionObject_argsHelper();
			
			public static updateActPromotionObject_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateActPromotionObject_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.model.sync.ActObjectUpdateRequest value;
					
					value = new com.vip.pms.data.model.sync.ActObjectUpdateRequest();
					com.vip.pms.data.model.sync.ActObjectUpdateRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateActPromotionObject_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.pms.data.model.sync.ActObjectUpdateRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateActPromotionObject_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateActivityBaseInfo_argsHelper : TBeanSerializer<updateActivityBaseInfo_args>
		{
			
			public static updateActivityBaseInfo_argsHelper OBJ = new updateActivityBaseInfo_argsHelper();
			
			public static updateActivityBaseInfo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateActivityBaseInfo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.ActivityRequestModel value;
					
					value = new com.vip.pms.data.service.ActivityRequestModel();
					com.vip.pms.data.service.ActivityRequestModelHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateActivityBaseInfo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.pms.data.service.ActivityRequestModelHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateActivityBaseInfo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateSpecialBaseInfo_argsHelper : TBeanSerializer<updateSpecialBaseInfo_args>
		{
			
			public static updateSpecialBaseInfo_argsHelper OBJ = new updateSpecialBaseInfo_argsHelper();
			
			public static updateSpecialBaseInfo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateSpecialBaseInfo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.SpecialRequestModel value;
					
					value = new com.vip.pms.data.service.SpecialRequestModel();
					com.vip.pms.data.service.SpecialRequestModelHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateSpecialBaseInfo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.pms.data.service.SpecialRequestModelHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateSpecialBaseInfo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateSpecialPromotionObject_argsHelper : TBeanSerializer<updateSpecialPromotionObject_args>
		{
			
			public static updateSpecialPromotionObject_argsHelper OBJ = new updateSpecialPromotionObject_argsHelper();
			
			public static updateSpecialPromotionObject_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateSpecialPromotionObject_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.model.sync.ActObjectUpdateRequest value;
					
					value = new com.vip.pms.data.model.sync.ActObjectUpdateRequest();
					com.vip.pms.data.model.sync.ActObjectUpdateRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateSpecialPromotionObject_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.pms.data.model.sync.ActObjectUpdateRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateSpecialPromotionObject_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addActivityUserLog_resultHelper : TBeanSerializer<addActivityUserLog_result>
		{
			
			public static addActivityUserLog_resultHelper OBJ = new addActivityUserLog_resultHelper();
			
			public static addActivityUserLog_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addActivityUserLog_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addActivityUserLog_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteBool((bool)structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("success can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addActivityUserLog_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addCommandPersonalCode_resultHelper : TBeanSerializer<addCommandPersonalCode_result>
		{
			
			public static addCommandPersonalCode_resultHelper OBJ = new addCommandPersonalCode_resultHelper();
			
			public static addCommandPersonalCode_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addCommandPersonalCode_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addCommandPersonalCode_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteBool((bool)structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("success can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addCommandPersonalCode_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addCommandUserLog_resultHelper : TBeanSerializer<addCommandUserLog_result>
		{
			
			public static addCommandUserLog_resultHelper OBJ = new addCommandUserLog_resultHelper();
			
			public static addCommandUserLog_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addCommandUserLog_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addCommandUserLog_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteBool((bool)structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("success can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addCommandUserLog_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addCouponUserLog_resultHelper : TBeanSerializer<addCouponUserLog_result>
		{
			
			public static addCouponUserLog_resultHelper OBJ = new addCouponUserLog_resultHelper();
			
			public static addCouponUserLog_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addCouponUserLog_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addCouponUserLog_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteBool((bool)structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("success can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addCouponUserLog_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addOldPmsOrderInfo_resultHelper : TBeanSerializer<addOldPmsOrderInfo_result>
		{
			
			public static addOldPmsOrderInfo_resultHelper OBJ = new addOldPmsOrderInfo_resultHelper();
			
			public static addOldPmsOrderInfo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addOldPmsOrderInfo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addOldPmsOrderInfo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteBool((bool)structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("success can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addOldPmsOrderInfo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addOrUpdateActivitySync_resultHelper : TBeanSerializer<addOrUpdateActivitySync_result>
		{
			
			public static addOrUpdateActivitySync_resultHelper OBJ = new addOrUpdateActivitySync_resultHelper();
			
			public static addOrUpdateActivitySync_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addOrUpdateActivitySync_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.SyncResult value;
					
					value = new com.vip.pms.data.service.SyncResult();
					com.vip.pms.data.service.SyncResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addOrUpdateActivitySync_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.pms.data.service.SyncResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addOrUpdateActivitySync_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addOrUpdateCommandSync_resultHelper : TBeanSerializer<addOrUpdateCommandSync_result>
		{
			
			public static addOrUpdateCommandSync_resultHelper OBJ = new addOrUpdateCommandSync_resultHelper();
			
			public static addOrUpdateCommandSync_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addOrUpdateCommandSync_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.SyncResult value;
					
					value = new com.vip.pms.data.service.SyncResult();
					com.vip.pms.data.service.SyncResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addOrUpdateCommandSync_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.pms.data.service.SyncResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addOrUpdateCommandSync_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addOrUpdateConfig_resultHelper : TBeanSerializer<addOrUpdateConfig_result>
		{
			
			public static addOrUpdateConfig_resultHelper OBJ = new addOrUpdateConfig_resultHelper();
			
			public static addOrUpdateConfig_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addOrUpdateConfig_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addOrUpdateConfig_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteBool((bool)structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("success can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addOrUpdateConfig_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addOrUpdateCouponGroupSync_resultHelper : TBeanSerializer<addOrUpdateCouponGroupSync_result>
		{
			
			public static addOrUpdateCouponGroupSync_resultHelper OBJ = new addOrUpdateCouponGroupSync_resultHelper();
			
			public static addOrUpdateCouponGroupSync_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addOrUpdateCouponGroupSync_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.SyncResult value;
					
					value = new com.vip.pms.data.service.SyncResult();
					com.vip.pms.data.service.SyncResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addOrUpdateCouponGroupSync_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.pms.data.service.SyncResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addOrUpdateCouponGroupSync_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addOrUpdateCouponRuleSync_resultHelper : TBeanSerializer<addOrUpdateCouponRuleSync_result>
		{
			
			public static addOrUpdateCouponRuleSync_resultHelper OBJ = new addOrUpdateCouponRuleSync_resultHelper();
			
			public static addOrUpdateCouponRuleSync_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addOrUpdateCouponRuleSync_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.SyncResult value;
					
					value = new com.vip.pms.data.service.SyncResult();
					com.vip.pms.data.service.SyncResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addOrUpdateCouponRuleSync_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.pms.data.service.SyncResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addOrUpdateCouponRuleSync_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addOrUpdateCouponSync_resultHelper : TBeanSerializer<addOrUpdateCouponSync_result>
		{
			
			public static addOrUpdateCouponSync_resultHelper OBJ = new addOrUpdateCouponSync_resultHelper();
			
			public static addOrUpdateCouponSync_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addOrUpdateCouponSync_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.SyncResult value;
					
					value = new com.vip.pms.data.service.SyncResult();
					com.vip.pms.data.service.SyncResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addOrUpdateCouponSync_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.pms.data.service.SyncResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addOrUpdateCouponSync_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addOrUpdatePaySync_resultHelper : TBeanSerializer<addOrUpdatePaySync_result>
		{
			
			public static addOrUpdatePaySync_resultHelper OBJ = new addOrUpdatePaySync_resultHelper();
			
			public static addOrUpdatePaySync_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addOrUpdatePaySync_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.SyncResult value;
					
					value = new com.vip.pms.data.service.SyncResult();
					com.vip.pms.data.service.SyncResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addOrUpdatePaySync_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.pms.data.service.SyncResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addOrUpdatePaySync_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addOrUpdatePrepayInfoSync_resultHelper : TBeanSerializer<addOrUpdatePrepayInfoSync_result>
		{
			
			public static addOrUpdatePrepayInfoSync_resultHelper OBJ = new addOrUpdatePrepayInfoSync_resultHelper();
			
			public static addOrUpdatePrepayInfoSync_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addOrUpdatePrepayInfoSync_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.SyncResult value;
					
					value = new com.vip.pms.data.service.SyncResult();
					com.vip.pms.data.service.SyncResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addOrUpdatePrepayInfoSync_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.pms.data.service.SyncResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addOrUpdatePrepayInfoSync_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addOrUpdateSpecialSync_resultHelper : TBeanSerializer<addOrUpdateSpecialSync_result>
		{
			
			public static addOrUpdateSpecialSync_resultHelper OBJ = new addOrUpdateSpecialSync_resultHelper();
			
			public static addOrUpdateSpecialSync_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addOrUpdateSpecialSync_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.SyncResult value;
					
					value = new com.vip.pms.data.service.SyncResult();
					com.vip.pms.data.service.SyncResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addOrUpdateSpecialSync_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.pms.data.service.SyncResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addOrUpdateSpecialSync_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addOrUpdateSurprisePriceActivitySync_resultHelper : TBeanSerializer<addOrUpdateSurprisePriceActivitySync_result>
		{
			
			public static addOrUpdateSurprisePriceActivitySync_resultHelper OBJ = new addOrUpdateSurprisePriceActivitySync_resultHelper();
			
			public static addOrUpdateSurprisePriceActivitySync_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addOrUpdateSurprisePriceActivitySync_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addOrUpdateSurprisePriceActivitySync_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addOrUpdateSurprisePriceActivitySync_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addPayUserLog_resultHelper : TBeanSerializer<addPayUserLog_result>
		{
			
			public static addPayUserLog_resultHelper OBJ = new addPayUserLog_resultHelper();
			
			public static addPayUserLog_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addPayUserLog_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addPayUserLog_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteBool((bool)structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("success can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addPayUserLog_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addSpecialUserLog_resultHelper : TBeanSerializer<addSpecialUserLog_result>
		{
			
			public static addSpecialUserLog_resultHelper OBJ = new addSpecialUserLog_resultHelper();
			
			public static addSpecialUserLog_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addSpecialUserLog_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addSpecialUserLog_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteBool((bool)structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("success can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addSpecialUserLog_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchModifyCouponTime_resultHelper : TBeanSerializer<batchModifyCouponTime_result>
		{
			
			public static batchModifyCouponTime_resultHelper OBJ = new batchModifyCouponTime_resultHelper();
			
			public static batchModifyCouponTime_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchModifyCouponTime_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.SyncResult value;
					
					value = new com.vip.pms.data.service.SyncResult();
					com.vip.pms.data.service.SyncResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(batchModifyCouponTime_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.pms.data.service.SyncResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchModifyCouponTime_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class buildAllActivityIndex_resultHelper : TBeanSerializer<buildAllActivityIndex_result>
		{
			
			public static buildAllActivityIndex_resultHelper OBJ = new buildAllActivityIndex_resultHelper();
			
			public static buildAllActivityIndex_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(buildAllActivityIndex_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(buildAllActivityIndex_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteBool((bool)structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("success can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(buildAllActivityIndex_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class cancelActivitySync_resultHelper : TBeanSerializer<cancelActivitySync_result>
		{
			
			public static cancelActivitySync_resultHelper OBJ = new cancelActivitySync_resultHelper();
			
			public static cancelActivitySync_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(cancelActivitySync_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.SyncResult value;
					
					value = new com.vip.pms.data.service.SyncResult();
					com.vip.pms.data.service.SyncResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(cancelActivitySync_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.pms.data.service.SyncResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(cancelActivitySync_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class cancelCommandSync_resultHelper : TBeanSerializer<cancelCommandSync_result>
		{
			
			public static cancelCommandSync_resultHelper OBJ = new cancelCommandSync_resultHelper();
			
			public static cancelCommandSync_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(cancelCommandSync_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.SyncResult value;
					
					value = new com.vip.pms.data.service.SyncResult();
					com.vip.pms.data.service.SyncResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(cancelCommandSync_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.pms.data.service.SyncResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(cancelCommandSync_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class cancelOrOfflineCouponGroupSync_resultHelper : TBeanSerializer<cancelOrOfflineCouponGroupSync_result>
		{
			
			public static cancelOrOfflineCouponGroupSync_resultHelper OBJ = new cancelOrOfflineCouponGroupSync_resultHelper();
			
			public static cancelOrOfflineCouponGroupSync_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(cancelOrOfflineCouponGroupSync_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.SyncResult value;
					
					value = new com.vip.pms.data.service.SyncResult();
					com.vip.pms.data.service.SyncResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(cancelOrOfflineCouponGroupSync_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.pms.data.service.SyncResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(cancelOrOfflineCouponGroupSync_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class cancelOrOfflineCouponRuleSync_resultHelper : TBeanSerializer<cancelOrOfflineCouponRuleSync_result>
		{
			
			public static cancelOrOfflineCouponRuleSync_resultHelper OBJ = new cancelOrOfflineCouponRuleSync_resultHelper();
			
			public static cancelOrOfflineCouponRuleSync_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(cancelOrOfflineCouponRuleSync_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.SyncResult value;
					
					value = new com.vip.pms.data.service.SyncResult();
					com.vip.pms.data.service.SyncResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(cancelOrOfflineCouponRuleSync_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.pms.data.service.SyncResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(cancelOrOfflineCouponRuleSync_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class cancelOrOfflineCouponSync_resultHelper : TBeanSerializer<cancelOrOfflineCouponSync_result>
		{
			
			public static cancelOrOfflineCouponSync_resultHelper OBJ = new cancelOrOfflineCouponSync_resultHelper();
			
			public static cancelOrOfflineCouponSync_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(cancelOrOfflineCouponSync_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.SyncResult value;
					
					value = new com.vip.pms.data.service.SyncResult();
					com.vip.pms.data.service.SyncResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(cancelOrOfflineCouponSync_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.pms.data.service.SyncResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(cancelOrOfflineCouponSync_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class cancelOrder_resultHelper : TBeanSerializer<cancelOrder_result>
		{
			
			public static cancelOrder_resultHelper OBJ = new cancelOrder_resultHelper();
			
			public static cancelOrder_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(cancelOrder_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(cancelOrder_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteBool((bool)structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("success can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(cancelOrder_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class cancelPaySync_resultHelper : TBeanSerializer<cancelPaySync_result>
		{
			
			public static cancelPaySync_resultHelper OBJ = new cancelPaySync_resultHelper();
			
			public static cancelPaySync_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(cancelPaySync_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.SyncResult value;
					
					value = new com.vip.pms.data.service.SyncResult();
					com.vip.pms.data.service.SyncResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(cancelPaySync_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.pms.data.service.SyncResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(cancelPaySync_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class cancelSpecialSync_resultHelper : TBeanSerializer<cancelSpecialSync_result>
		{
			
			public static cancelSpecialSync_resultHelper OBJ = new cancelSpecialSync_resultHelper();
			
			public static cancelSpecialSync_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(cancelSpecialSync_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.SyncResult value;
					
					value = new com.vip.pms.data.service.SyncResult();
					com.vip.pms.data.service.SyncResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(cancelSpecialSync_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.pms.data.service.SyncResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(cancelSpecialSync_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class cancelSurprisePriceActivitySync_resultHelper : TBeanSerializer<cancelSurprisePriceActivitySync_result>
		{
			
			public static cancelSurprisePriceActivitySync_resultHelper OBJ = new cancelSurprisePriceActivitySync_resultHelper();
			
			public static cancelSurprisePriceActivitySync_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(cancelSurprisePriceActivitySync_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(cancelSurprisePriceActivitySync_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(cancelSurprisePriceActivitySync_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class check_resultHelper : TBeanSerializer<check_result>
		{
			
			public static check_resultHelper OBJ = new check_resultHelper();
			
			public static check_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(check_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.CheckResult value;
					
					value = new com.vip.pms.data.service.CheckResult();
					com.vip.pms.data.service.CheckResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(check_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.pms.data.service.CheckResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(check_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class couponActivate_resultHelper : TBeanSerializer<couponActivate_result>
		{
			
			public static couponActivate_resultHelper OBJ = new couponActivate_resultHelper();
			
			public static couponActivate_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(couponActivate_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.CouponResResult value;
					
					value = new com.vip.pms.data.service.CouponResResult();
					com.vip.pms.data.service.CouponResResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(couponActivate_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.pms.data.service.CouponResResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(couponActivate_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class couponBind_resultHelper : TBeanSerializer<couponBind_result>
		{
			
			public static couponBind_resultHelper OBJ = new couponBind_resultHelper();
			
			public static couponBind_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(couponBind_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.CouponResResult value;
					
					value = new com.vip.pms.data.service.CouponResResult();
					com.vip.pms.data.service.CouponResResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(couponBind_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.pms.data.service.CouponResResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(couponBind_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class couponGroupActivate_resultHelper : TBeanSerializer<couponGroupActivate_result>
		{
			
			public static couponGroupActivate_resultHelper OBJ = new couponGroupActivate_resultHelper();
			
			public static couponGroupActivate_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(couponGroupActivate_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.CouponResResult value;
					
					value = new com.vip.pms.data.service.CouponResResult();
					com.vip.pms.data.service.CouponResResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(couponGroupActivate_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.pms.data.service.CouponResResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(couponGroupActivate_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class couponGroupBind_resultHelper : TBeanSerializer<couponGroupBind_result>
		{
			
			public static couponGroupBind_resultHelper OBJ = new couponGroupBind_resultHelper();
			
			public static couponGroupBind_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(couponGroupBind_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.CouponResResult value;
					
					value = new com.vip.pms.data.service.CouponResResult();
					com.vip.pms.data.service.CouponResResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(couponGroupBind_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.pms.data.service.CouponResResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(couponGroupBind_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class delGoodsOriginalPrice_resultHelper : TBeanSerializer<delGoodsOriginalPrice_result>
		{
			
			public static delGoodsOriginalPrice_resultHelper OBJ = new delGoodsOriginalPrice_resultHelper();
			
			public static delGoodsOriginalPrice_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(delGoodsOriginalPrice_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(delGoodsOriginalPrice_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(delGoodsOriginalPrice_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class delGoodsSurprisePrice_resultHelper : TBeanSerializer<delGoodsSurprisePrice_result>
		{
			
			public static delGoodsSurprisePrice_resultHelper OBJ = new delGoodsSurprisePrice_resultHelper();
			
			public static delGoodsSurprisePrice_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(delGoodsSurprisePrice_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(delGoodsSurprisePrice_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(delGoodsSurprisePrice_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class deleteConfig_resultHelper : TBeanSerializer<deleteConfig_result>
		{
			
			public static deleteConfig_resultHelper OBJ = new deleteConfig_resultHelper();
			
			public static deleteConfig_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(deleteConfig_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(deleteConfig_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteBool((bool)structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("success can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(deleteConfig_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class deletePrepayInfoByMidSync_resultHelper : TBeanSerializer<deletePrepayInfoByMidSync_result>
		{
			
			public static deletePrepayInfoByMidSync_resultHelper OBJ = new deletePrepayInfoByMidSync_resultHelper();
			
			public static deletePrepayInfoByMidSync_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(deletePrepayInfoByMidSync_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.SyncResult value;
					
					value = new com.vip.pms.data.service.SyncResult();
					com.vip.pms.data.service.SyncResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(deletePrepayInfoByMidSync_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.pms.data.service.SyncResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(deletePrepayInfoByMidSync_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class deletePrepayInfoSync_resultHelper : TBeanSerializer<deletePrepayInfoSync_result>
		{
			
			public static deletePrepayInfoSync_resultHelper OBJ = new deletePrepayInfoSync_resultHelper();
			
			public static deletePrepayInfoSync_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(deletePrepayInfoSync_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.SyncResult value;
					
					value = new com.vip.pms.data.service.SyncResult();
					com.vip.pms.data.service.SyncResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(deletePrepayInfoSync_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.pms.data.service.SyncResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(deletePrepayInfoSync_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class exportCoupon_resultHelper : TBeanSerializer<exportCoupon_result>
		{
			
			public static exportCoupon_resultHelper OBJ = new exportCoupon_resultHelper();
			
			public static exportCoupon_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(exportCoupon_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.pms.data.service.ExportRespModel> value;
					
					value = new List<com.vip.pms.data.service.ExportRespModel>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.pms.data.service.ExportRespModel elem0;
							
							elem0 = new com.vip.pms.data.service.ExportRespModel();
							com.vip.pms.data.service.ExportRespModelHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(exportCoupon_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.pms.data.service.ExportRespModel _item0 in structs.GetSuccess()){
						
						
						com.vip.pms.data.service.ExportRespModelHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(exportCoupon_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class exportCouponGroup_resultHelper : TBeanSerializer<exportCouponGroup_result>
		{
			
			public static exportCouponGroup_resultHelper OBJ = new exportCouponGroup_resultHelper();
			
			public static exportCouponGroup_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(exportCouponGroup_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.pms.data.service.ExportRespModel> value;
					
					value = new List<com.vip.pms.data.service.ExportRespModel>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.pms.data.service.ExportRespModel elem1;
							
							elem1 = new com.vip.pms.data.service.ExportRespModel();
							com.vip.pms.data.service.ExportRespModelHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(exportCouponGroup_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.pms.data.service.ExportRespModel _item0 in structs.GetSuccess()){
						
						
						com.vip.pms.data.service.ExportRespModelHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(exportCouponGroup_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class fetchCommandOrderNos_resultHelper : TBeanSerializer<fetchCommandOrderNos_result>
		{
			
			public static fetchCommandOrderNos_resultHelper OBJ = new fetchCommandOrderNos_resultHelper();
			
			public static fetchCommandOrderNos_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(fetchCommandOrderNos_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.OrderNosResult value;
					
					value = new com.vip.pms.data.service.OrderNosResult();
					com.vip.pms.data.service.OrderNosResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(fetchCommandOrderNos_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.pms.data.service.OrderNosResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(fetchCommandOrderNos_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class fetchOrder_resultHelper : TBeanSerializer<fetchOrder_result>
		{
			
			public static fetchOrder_resultHelper OBJ = new fetchOrder_resultHelper();
			
			public static fetchOrder_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(fetchOrder_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.OrderResult value;
					
					value = new com.vip.pms.data.service.OrderResult();
					com.vip.pms.data.service.OrderResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(fetchOrder_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.pms.data.service.OrderResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(fetchOrder_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class flushCouponRuleIndexSync_resultHelper : TBeanSerializer<flushCouponRuleIndexSync_result>
		{
			
			public static flushCouponRuleIndexSync_resultHelper OBJ = new flushCouponRuleIndexSync_resultHelper();
			
			public static flushCouponRuleIndexSync_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(flushCouponRuleIndexSync_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.SyncResult value;
					
					value = new com.vip.pms.data.service.SyncResult();
					com.vip.pms.data.service.SyncResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(flushCouponRuleIndexSync_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.pms.data.service.SyncResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(flushCouponRuleIndexSync_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class flushGoodsOriginalPrice_resultHelper : TBeanSerializer<flushGoodsOriginalPrice_result>
		{
			
			public static flushGoodsOriginalPrice_resultHelper OBJ = new flushGoodsOriginalPrice_resultHelper();
			
			public static flushGoodsOriginalPrice_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(flushGoodsOriginalPrice_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(flushGoodsOriginalPrice_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(flushGoodsOriginalPrice_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class flushGoodsSurprisePrice_resultHelper : TBeanSerializer<flushGoodsSurprisePrice_result>
		{
			
			public static flushGoodsSurprisePrice_resultHelper OBJ = new flushGoodsSurprisePrice_resultHelper();
			
			public static flushGoodsSurprisePrice_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(flushGoodsSurprisePrice_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(flushGoodsSurprisePrice_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(flushGoodsSurprisePrice_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getConfig_resultHelper : TBeanSerializer<getConfig_result>
		{
			
			public static getConfig_resultHelper OBJ = new getConfig_resultHelper();
			
			public static getConfig_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getConfig_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.pms.data.service.AdminConfigModel> value;
					
					value = new List<com.vip.pms.data.service.AdminConfigModel>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.pms.data.service.AdminConfigModel elem0;
							
							elem0 = new com.vip.pms.data.service.AdminConfigModel();
							com.vip.pms.data.service.AdminConfigModelHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getConfig_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.pms.data.service.AdminConfigModel _item0 in structs.GetSuccess()){
						
						
						com.vip.pms.data.service.AdminConfigModelHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getConfig_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getTypeConfig_resultHelper : TBeanSerializer<getTypeConfig_result>
		{
			
			public static getTypeConfig_resultHelper OBJ = new getTypeConfig_resultHelper();
			
			public static getTypeConfig_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getTypeConfig_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.pms.data.service.AdminConfigModel> value;
					
					value = new List<com.vip.pms.data.service.AdminConfigModel>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.pms.data.service.AdminConfigModel elem1;
							
							elem1 = new com.vip.pms.data.service.AdminConfigModel();
							com.vip.pms.data.service.AdminConfigModelHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getTypeConfig_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.pms.data.service.AdminConfigModel _item0 in structs.GetSuccess()){
						
						
						com.vip.pms.data.service.AdminConfigModelHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getTypeConfig_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class healthCheck_resultHelper : TBeanSerializer<healthCheck_result>
		{
			
			public static healthCheck_resultHelper OBJ = new healthCheck_resultHelper();
			
			public static healthCheck_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(healthCheck_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.hermes.core.health.CheckResult value;
					
					value = new com.vip.hermes.core.health.CheckResult();
					com.vip.hermes.core.health.CheckResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(healthCheck_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.hermes.core.health.CheckResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(healthCheck_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class modifyCacheSwitchStatus_resultHelper : TBeanSerializer<modifyCacheSwitchStatus_result>
		{
			
			public static modifyCacheSwitchStatus_resultHelper OBJ = new modifyCacheSwitchStatus_resultHelper();
			
			public static modifyCacheSwitchStatus_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(modifyCacheSwitchStatus_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(modifyCacheSwitchStatus_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteBool((bool)structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("success can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(modifyCacheSwitchStatus_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class modifyCouponTime_resultHelper : TBeanSerializer<modifyCouponTime_result>
		{
			
			public static modifyCouponTime_resultHelper OBJ = new modifyCouponTime_resultHelper();
			
			public static modifyCouponTime_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(modifyCouponTime_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.SyncResult value;
					
					value = new com.vip.pms.data.service.SyncResult();
					com.vip.pms.data.service.SyncResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(modifyCouponTime_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.pms.data.service.SyncResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(modifyCouponTime_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class modifyCouponTimeByUserIds_resultHelper : TBeanSerializer<modifyCouponTimeByUserIds_result>
		{
			
			public static modifyCouponTimeByUserIds_resultHelper OBJ = new modifyCouponTimeByUserIds_resultHelper();
			
			public static modifyCouponTimeByUserIds_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(modifyCouponTimeByUserIds_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.SyncResult value;
					
					value = new com.vip.pms.data.service.SyncResult();
					com.vip.pms.data.service.SyncResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(modifyCouponTimeByUserIds_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.pms.data.service.SyncResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(modifyCouponTimeByUserIds_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class multiBind_resultHelper : TBeanSerializer<multiBind_result>
		{
			
			public static multiBind_resultHelper OBJ = new multiBind_resultHelper();
			
			public static multiBind_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(multiBind_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.pms.data.coupon.model.CouponMultiBindResponse> value;
					
					value = new List<com.vip.pms.data.coupon.model.CouponMultiBindResponse>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.pms.data.coupon.model.CouponMultiBindResponse elem0;
							
							elem0 = new com.vip.pms.data.coupon.model.CouponMultiBindResponse();
							com.vip.pms.data.coupon.model.CouponMultiBindResponseHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(multiBind_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.pms.data.coupon.model.CouponMultiBindResponse _item0 in structs.GetSuccess()){
						
						
						com.vip.pms.data.coupon.model.CouponMultiBindResponseHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(multiBind_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class multiBindSyncMode_resultHelper : TBeanSerializer<multiBindSyncMode_result>
		{
			
			public static multiBindSyncMode_resultHelper OBJ = new multiBindSyncMode_resultHelper();
			
			public static multiBindSyncMode_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(multiBindSyncMode_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.pms.data.coupon.model.CouponMultiBindResponse> value;
					
					value = new List<com.vip.pms.data.coupon.model.CouponMultiBindResponse>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.pms.data.coupon.model.CouponMultiBindResponse elem1;
							
							elem1 = new com.vip.pms.data.coupon.model.CouponMultiBindResponse();
							com.vip.pms.data.coupon.model.CouponMultiBindResponseHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(multiBindSyncMode_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.pms.data.coupon.model.CouponMultiBindResponse _item0 in structs.GetSuccess()){
						
						
						com.vip.pms.data.coupon.model.CouponMultiBindResponseHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(multiBindSyncMode_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class offlineActivityCallback_resultHelper : TBeanSerializer<offlineActivityCallback_result>
		{
			
			public static offlineActivityCallback_resultHelper OBJ = new offlineActivityCallback_resultHelper();
			
			public static offlineActivityCallback_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(offlineActivityCallback_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(offlineActivityCallback_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteBool((bool)structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("success can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(offlineActivityCallback_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class offlineActivitySync_resultHelper : TBeanSerializer<offlineActivitySync_result>
		{
			
			public static offlineActivitySync_resultHelper OBJ = new offlineActivitySync_resultHelper();
			
			public static offlineActivitySync_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(offlineActivitySync_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.SyncResult value;
					
					value = new com.vip.pms.data.service.SyncResult();
					com.vip.pms.data.service.SyncResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(offlineActivitySync_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.pms.data.service.SyncResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(offlineActivitySync_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class offlineCommandSync_resultHelper : TBeanSerializer<offlineCommandSync_result>
		{
			
			public static offlineCommandSync_resultHelper OBJ = new offlineCommandSync_resultHelper();
			
			public static offlineCommandSync_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(offlineCommandSync_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.SyncResult value;
					
					value = new com.vip.pms.data.service.SyncResult();
					com.vip.pms.data.service.SyncResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(offlineCommandSync_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.pms.data.service.SyncResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(offlineCommandSync_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class offlinePaySync_resultHelper : TBeanSerializer<offlinePaySync_result>
		{
			
			public static offlinePaySync_resultHelper OBJ = new offlinePaySync_resultHelper();
			
			public static offlinePaySync_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(offlinePaySync_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.SyncResult value;
					
					value = new com.vip.pms.data.service.SyncResult();
					com.vip.pms.data.service.SyncResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(offlinePaySync_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.pms.data.service.SyncResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(offlinePaySync_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class offlinePrepayInfoSync_resultHelper : TBeanSerializer<offlinePrepayInfoSync_result>
		{
			
			public static offlinePrepayInfoSync_resultHelper OBJ = new offlinePrepayInfoSync_resultHelper();
			
			public static offlinePrepayInfoSync_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(offlinePrepayInfoSync_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.SyncResult value;
					
					value = new com.vip.pms.data.service.SyncResult();
					com.vip.pms.data.service.SyncResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(offlinePrepayInfoSync_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.pms.data.service.SyncResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(offlinePrepayInfoSync_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class offlineSpecialSync_resultHelper : TBeanSerializer<offlineSpecialSync_result>
		{
			
			public static offlineSpecialSync_resultHelper OBJ = new offlineSpecialSync_resultHelper();
			
			public static offlineSpecialSync_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(offlineSpecialSync_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.SyncResult value;
					
					value = new com.vip.pms.data.service.SyncResult();
					com.vip.pms.data.service.SyncResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(offlineSpecialSync_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.pms.data.service.SyncResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(offlineSpecialSync_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class offlineSurprisePriceActivitySync_resultHelper : TBeanSerializer<offlineSurprisePriceActivitySync_result>
		{
			
			public static offlineSurprisePriceActivitySync_resultHelper OBJ = new offlineSurprisePriceActivitySync_resultHelper();
			
			public static offlineSurprisePriceActivitySync_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(offlineSurprisePriceActivitySync_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(offlineSurprisePriceActivitySync_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(offlineSurprisePriceActivitySync_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class prepareActivity_resultHelper : TBeanSerializer<prepareActivity_result>
		{
			
			public static prepareActivity_resultHelper OBJ = new prepareActivity_resultHelper();
			
			public static prepareActivity_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(prepareActivity_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.model.sync.PrepareActivityResult value;
					
					value = new com.vip.pms.data.model.sync.PrepareActivityResult();
					com.vip.pms.data.model.sync.PrepareActivityResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(prepareActivity_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.pms.data.model.sync.PrepareActivityResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(prepareActivity_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class prepareSpecial_resultHelper : TBeanSerializer<prepareSpecial_result>
		{
			
			public static prepareSpecial_resultHelper OBJ = new prepareSpecial_resultHelper();
			
			public static prepareSpecial_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(prepareSpecial_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.model.sync.PrepareActivityResult value;
					
					value = new com.vip.pms.data.model.sync.PrepareActivityResult();
					com.vip.pms.data.model.sync.PrepareActivityResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(prepareSpecial_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.pms.data.model.sync.PrepareActivityResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(prepareSpecial_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class publishRollbackUseCouponMsg_resultHelper : TBeanSerializer<publishRollbackUseCouponMsg_result>
		{
			
			public static publishRollbackUseCouponMsg_resultHelper OBJ = new publishRollbackUseCouponMsg_resultHelper();
			
			public static publishRollbackUseCouponMsg_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(publishRollbackUseCouponMsg_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(publishRollbackUseCouponMsg_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteBool((bool)structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("success can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(publishRollbackUseCouponMsg_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class pushOfflineActivities_resultHelper : TBeanSerializer<pushOfflineActivities_result>
		{
			
			public static pushOfflineActivities_resultHelper OBJ = new pushOfflineActivities_resultHelper();
			
			public static pushOfflineActivities_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(pushOfflineActivities_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.pms.data.service.SyncResult value;
					
					value = new com.vip.pms.data.service.SyncResult();
					com.vip.pms.data.service.SyncResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(pushOfflineActivities_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.pms.data.service.SyncResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(pushOfflineActivities_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryConfirmationNo_resultHelper : TBeanSerializer<queryConfirmationNo_result>
		{
			
			public static queryConfirmationNo_resultHelper OBJ = new queryConfirmationNo_resultHelper();
			
			public static queryConfirmationNo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryConfirmationNo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.pms.data.service.ConfirmationResult> value;
					
					value = new List<com.vip.pms.data.service.ConfirmationResult>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.pms.data.service.ConfirmationResult elem0;
							
							elem0 = new com.vip.pms.data.service.ConfirmationResult();
							com.vip.pms.data.service.ConfirmationResultHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryConfirmationNo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.pms.data.service.ConfirmationResult _item0 in structs.GetSuccess()){
						
						
						com.vip.pms.data.service.ConfirmationResultHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryConfirmationNo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryCouponInstanceStat_resultHelper : TBeanSerializer<queryCouponInstanceStat_result>
		{
			
			public static queryCouponInstanceStat_resultHelper OBJ = new queryCouponInstanceStat_resultHelper();
			
			public static queryCouponInstanceStat_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryCouponInstanceStat_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.pms.data.service.CouponInstanceStatResponse> value;
					
					value = new List<com.vip.pms.data.service.CouponInstanceStatResponse>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.pms.data.service.CouponInstanceStatResponse elem1;
							
							elem1 = new com.vip.pms.data.service.CouponInstanceStatResponse();
							com.vip.pms.data.service.CouponInstanceStatResponseHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryCouponInstanceStat_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.pms.data.service.CouponInstanceStatResponse _item0 in structs.GetSuccess()){
						
						
						com.vip.pms.data.service.CouponInstanceStatResponseHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryCouponInstanceStat_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryGoodsFavAmount_resultHelper : TBeanSerializer<queryGoodsFavAmount_result>
		{
			
			public static queryGoodsFavAmount_resultHelper OBJ = new queryGoodsFavAmount_resultHelper();
			
			public static queryGoodsFavAmount_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryGoodsFavAmount_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.pms.data.service.OrderFavDetailResult> value;
					
					value = new List<com.vip.pms.data.service.OrderFavDetailResult>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.pms.data.service.OrderFavDetailResult elem1;
							
							elem1 = new com.vip.pms.data.service.OrderFavDetailResult();
							com.vip.pms.data.service.OrderFavDetailResultHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryGoodsFavAmount_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.pms.data.service.OrderFavDetailResult _item0 in structs.GetSuccess()){
						
						
						com.vip.pms.data.service.OrderFavDetailResultHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryGoodsFavAmount_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class refreshOrder_resultHelper : TBeanSerializer<refreshOrder_result>
		{
			
			public static refreshOrder_resultHelper OBJ = new refreshOrder_resultHelper();
			
			public static refreshOrder_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(refreshOrder_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(refreshOrder_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteBool((bool)structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("success can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(refreshOrder_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class returnCoupon_resultHelper : TBeanSerializer<returnCoupon_result>
		{
			
			public static returnCoupon_resultHelper OBJ = new returnCoupon_resultHelper();
			
			public static returnCoupon_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(returnCoupon_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(returnCoupon_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteBool((bool)structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("success can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(returnCoupon_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class saveActPromotionObject_resultHelper : TBeanSerializer<saveActPromotionObject_result>
		{
			
			public static saveActPromotionObject_resultHelper OBJ = new saveActPromotionObject_resultHelper();
			
			public static saveActPromotionObject_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(saveActPromotionObject_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(saveActPromotionObject_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(saveActPromotionObject_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class saveActivity_resultHelper : TBeanSerializer<saveActivity_result>
		{
			
			public static saveActivity_resultHelper OBJ = new saveActivity_resultHelper();
			
			public static saveActivity_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(saveActivity_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(saveActivity_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(saveActivity_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class saveSpecial_resultHelper : TBeanSerializer<saveSpecial_result>
		{
			
			public static saveSpecial_resultHelper OBJ = new saveSpecial_resultHelper();
			
			public static saveSpecial_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(saveSpecial_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(saveSpecial_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(saveSpecial_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class saveSpecialPromotionObject_resultHelper : TBeanSerializer<saveSpecialPromotionObject_result>
		{
			
			public static saveSpecialPromotionObject_resultHelper OBJ = new saveSpecialPromotionObject_resultHelper();
			
			public static saveSpecialPromotionObject_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(saveSpecialPromotionObject_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(saveSpecialPromotionObject_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(saveSpecialPromotionObject_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class submitSMSendingRequest_resultHelper : TBeanSerializer<submitSMSendingRequest_result>
		{
			
			public static submitSMSendingRequest_resultHelper OBJ = new submitSMSendingRequest_resultHelper();
			
			public static submitSMSendingRequest_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(submitSMSendingRequest_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(submitSMSendingRequest_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(submitSMSendingRequest_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class syncAllActivityIndex_resultHelper : TBeanSerializer<syncAllActivityIndex_result>
		{
			
			public static syncAllActivityIndex_resultHelper OBJ = new syncAllActivityIndex_resultHelper();
			
			public static syncAllActivityIndex_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(syncAllActivityIndex_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(syncAllActivityIndex_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteBool((bool)structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("success can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(syncAllActivityIndex_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class syncAllCacheByCacheType_resultHelper : TBeanSerializer<syncAllCacheByCacheType_result>
		{
			
			public static syncAllCacheByCacheType_resultHelper OBJ = new syncAllCacheByCacheType_resultHelper();
			
			public static syncAllCacheByCacheType_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(syncAllCacheByCacheType_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(syncAllCacheByCacheType_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteBool((bool)structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("success can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(syncAllCacheByCacheType_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class syncAllGoodsOriginalPrice_resultHelper : TBeanSerializer<syncAllGoodsOriginalPrice_result>
		{
			
			public static syncAllGoodsOriginalPrice_resultHelper OBJ = new syncAllGoodsOriginalPrice_resultHelper();
			
			public static syncAllGoodsOriginalPrice_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(syncAllGoodsOriginalPrice_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(syncAllGoodsOriginalPrice_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(syncAllGoodsOriginalPrice_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class syncAllGoodsSurprisePrice_resultHelper : TBeanSerializer<syncAllGoodsSurprisePrice_result>
		{
			
			public static syncAllGoodsSurprisePrice_resultHelper OBJ = new syncAllGoodsSurprisePrice_resultHelper();
			
			public static syncAllGoodsSurprisePrice_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(syncAllGoodsSurprisePrice_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(syncAllGoodsSurprisePrice_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(syncAllGoodsSurprisePrice_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class syncBiPush_resultHelper : TBeanSerializer<syncBiPush_result>
		{
			
			public static syncBiPush_resultHelper OBJ = new syncBiPush_resultHelper();
			
			public static syncBiPush_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(syncBiPush_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(syncBiPush_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteBool((bool)structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("success can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(syncBiPush_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class syncBlacklistNew_resultHelper : TBeanSerializer<syncBlacklistNew_result>
		{
			
			public static syncBlacklistNew_resultHelper OBJ = new syncBlacklistNew_resultHelper();
			
			public static syncBlacklistNew_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(syncBlacklistNew_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(syncBlacklistNew_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteBool((bool)structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("success can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(syncBlacklistNew_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class syncCacheByActivityNosAndCacheType_resultHelper : TBeanSerializer<syncCacheByActivityNosAndCacheType_result>
		{
			
			public static syncCacheByActivityNosAndCacheType_resultHelper OBJ = new syncCacheByActivityNosAndCacheType_resultHelper();
			
			public static syncCacheByActivityNosAndCacheType_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(syncCacheByActivityNosAndCacheType_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(syncCacheByActivityNosAndCacheType_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteBool((bool)structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("success can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(syncCacheByActivityNosAndCacheType_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class syncPayBlackList_resultHelper : TBeanSerializer<syncPayBlackList_result>
		{
			
			public static syncPayBlackList_resultHelper OBJ = new syncPayBlackList_resultHelper();
			
			public static syncPayBlackList_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(syncPayBlackList_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(syncPayBlackList_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteBool((bool)structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("success can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(syncPayBlackList_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateActPromotionObject_resultHelper : TBeanSerializer<updateActPromotionObject_result>
		{
			
			public static updateActPromotionObject_resultHelper OBJ = new updateActPromotionObject_resultHelper();
			
			public static updateActPromotionObject_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateActPromotionObject_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateActPromotionObject_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateActPromotionObject_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateActivityBaseInfo_resultHelper : TBeanSerializer<updateActivityBaseInfo_result>
		{
			
			public static updateActivityBaseInfo_resultHelper OBJ = new updateActivityBaseInfo_resultHelper();
			
			public static updateActivityBaseInfo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateActivityBaseInfo_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateActivityBaseInfo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateActivityBaseInfo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateSpecialBaseInfo_resultHelper : TBeanSerializer<updateSpecialBaseInfo_result>
		{
			
			public static updateSpecialBaseInfo_resultHelper OBJ = new updateSpecialBaseInfo_resultHelper();
			
			public static updateSpecialBaseInfo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateSpecialBaseInfo_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateSpecialBaseInfo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateSpecialBaseInfo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateSpecialPromotionObject_resultHelper : TBeanSerializer<updateSpecialPromotionObject_result>
		{
			
			public static updateSpecialPromotionObject_resultHelper OBJ = new updateSpecialPromotionObject_resultHelper();
			
			public static updateSpecialPromotionObject_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateSpecialPromotionObject_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateSpecialPromotionObject_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateSpecialPromotionObject_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class PmsDataServiceClient : OspRestStub , PmsDataService  {
			
			
			public PmsDataServiceClient():base("com.vip.pms.data.service.PmsDataService","1.0.0") {
				
				
			}
			
			
			
			public bool? addActivityUserLog(com.vip.pms.data.service.ActivityUserLogRequestModel request_) {
				
				send_addActivityUserLog(request_);
				return recv_addActivityUserLog(); 
				
			}
			
			
			private void send_addActivityUserLog(com.vip.pms.data.service.ActivityUserLogRequestModel request_){
				
				InitInvocation("addActivityUserLog");
				
				addActivityUserLog_args args = new addActivityUserLog_args();
				args.SetRequest(request_);
				
				SendBase(args, addActivityUserLog_argsHelper.getInstance());
			}
			
			
			private bool? recv_addActivityUserLog(){
				
				addActivityUserLog_result result = new addActivityUserLog_result();
				ReceiveBase(result, addActivityUserLog_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public bool? addCommandPersonalCode(string commandId_,string personalCode_) {
				
				send_addCommandPersonalCode(commandId_,personalCode_);
				return recv_addCommandPersonalCode(); 
				
			}
			
			
			private void send_addCommandPersonalCode(string commandId_,string personalCode_){
				
				InitInvocation("addCommandPersonalCode");
				
				addCommandPersonalCode_args args = new addCommandPersonalCode_args();
				args.SetCommandId(commandId_);
				args.SetPersonalCode(personalCode_);
				
				SendBase(args, addCommandPersonalCode_argsHelper.getInstance());
			}
			
			
			private bool? recv_addCommandPersonalCode(){
				
				addCommandPersonalCode_result result = new addCommandPersonalCode_result();
				ReceiveBase(result, addCommandPersonalCode_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public bool? addCommandUserLog(com.vip.pms.data.service.CommandUserLogRequestModel request_) {
				
				send_addCommandUserLog(request_);
				return recv_addCommandUserLog(); 
				
			}
			
			
			private void send_addCommandUserLog(com.vip.pms.data.service.CommandUserLogRequestModel request_){
				
				InitInvocation("addCommandUserLog");
				
				addCommandUserLog_args args = new addCommandUserLog_args();
				args.SetRequest(request_);
				
				SendBase(args, addCommandUserLog_argsHelper.getInstance());
			}
			
			
			private bool? recv_addCommandUserLog(){
				
				addCommandUserLog_result result = new addCommandUserLog_result();
				ReceiveBase(result, addCommandUserLog_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public bool? addCouponUserLog(com.vip.pms.data.service.CouponOrderRequestModel request_) {
				
				send_addCouponUserLog(request_);
				return recv_addCouponUserLog(); 
				
			}
			
			
			private void send_addCouponUserLog(com.vip.pms.data.service.CouponOrderRequestModel request_){
				
				InitInvocation("addCouponUserLog");
				
				addCouponUserLog_args args = new addCouponUserLog_args();
				args.SetRequest(request_);
				
				SendBase(args, addCouponUserLog_argsHelper.getInstance());
			}
			
			
			private bool? recv_addCouponUserLog(){
				
				addCouponUserLog_result result = new addCouponUserLog_result();
				ReceiveBase(result, addCouponUserLog_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public bool? addOldPmsOrderInfo(com.vip.pms.data.service.OldPmsOrderRequestModel request_) {
				
				send_addOldPmsOrderInfo(request_);
				return recv_addOldPmsOrderInfo(); 
				
			}
			
			
			private void send_addOldPmsOrderInfo(com.vip.pms.data.service.OldPmsOrderRequestModel request_){
				
				InitInvocation("addOldPmsOrderInfo");
				
				addOldPmsOrderInfo_args args = new addOldPmsOrderInfo_args();
				args.SetRequest(request_);
				
				SendBase(args, addOldPmsOrderInfo_argsHelper.getInstance());
			}
			
			
			private bool? recv_addOldPmsOrderInfo(){
				
				addOldPmsOrderInfo_result result = new addOldPmsOrderInfo_result();
				ReceiveBase(result, addOldPmsOrderInfo_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.pms.data.service.SyncResult addOrUpdateActivitySync(com.vip.pms.data.service.ActivityRequestModel activityRequestModel_) {
				
				send_addOrUpdateActivitySync(activityRequestModel_);
				return recv_addOrUpdateActivitySync(); 
				
			}
			
			
			private void send_addOrUpdateActivitySync(com.vip.pms.data.service.ActivityRequestModel activityRequestModel_){
				
				InitInvocation("addOrUpdateActivitySync");
				
				addOrUpdateActivitySync_args args = new addOrUpdateActivitySync_args();
				args.SetActivityRequestModel(activityRequestModel_);
				
				SendBase(args, addOrUpdateActivitySync_argsHelper.getInstance());
			}
			
			
			private com.vip.pms.data.service.SyncResult recv_addOrUpdateActivitySync(){
				
				addOrUpdateActivitySync_result result = new addOrUpdateActivitySync_result();
				ReceiveBase(result, addOrUpdateActivitySync_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.pms.data.service.SyncResult addOrUpdateCommandSync(com.vip.pms.data.service.CommandRequestModel commandRequestModel_) {
				
				send_addOrUpdateCommandSync(commandRequestModel_);
				return recv_addOrUpdateCommandSync(); 
				
			}
			
			
			private void send_addOrUpdateCommandSync(com.vip.pms.data.service.CommandRequestModel commandRequestModel_){
				
				InitInvocation("addOrUpdateCommandSync");
				
				addOrUpdateCommandSync_args args = new addOrUpdateCommandSync_args();
				args.SetCommandRequestModel(commandRequestModel_);
				
				SendBase(args, addOrUpdateCommandSync_argsHelper.getInstance());
			}
			
			
			private com.vip.pms.data.service.SyncResult recv_addOrUpdateCommandSync(){
				
				addOrUpdateCommandSync_result result = new addOrUpdateCommandSync_result();
				ReceiveBase(result, addOrUpdateCommandSync_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public bool? addOrUpdateConfig(com.vip.pms.data.service.AdminConfigModel config_) {
				
				send_addOrUpdateConfig(config_);
				return recv_addOrUpdateConfig(); 
				
			}
			
			
			private void send_addOrUpdateConfig(com.vip.pms.data.service.AdminConfigModel config_){
				
				InitInvocation("addOrUpdateConfig");
				
				addOrUpdateConfig_args args = new addOrUpdateConfig_args();
				args.SetConfig(config_);
				
				SendBase(args, addOrUpdateConfig_argsHelper.getInstance());
			}
			
			
			private bool? recv_addOrUpdateConfig(){
				
				addOrUpdateConfig_result result = new addOrUpdateConfig_result();
				ReceiveBase(result, addOrUpdateConfig_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.pms.data.service.SyncResult addOrUpdateCouponGroupSync(com.vip.pms.data.service.CouponRequestModel couponRequestModel_) {
				
				send_addOrUpdateCouponGroupSync(couponRequestModel_);
				return recv_addOrUpdateCouponGroupSync(); 
				
			}
			
			
			private void send_addOrUpdateCouponGroupSync(com.vip.pms.data.service.CouponRequestModel couponRequestModel_){
				
				InitInvocation("addOrUpdateCouponGroupSync");
				
				addOrUpdateCouponGroupSync_args args = new addOrUpdateCouponGroupSync_args();
				args.SetCouponRequestModel(couponRequestModel_);
				
				SendBase(args, addOrUpdateCouponGroupSync_argsHelper.getInstance());
			}
			
			
			private com.vip.pms.data.service.SyncResult recv_addOrUpdateCouponGroupSync(){
				
				addOrUpdateCouponGroupSync_result result = new addOrUpdateCouponGroupSync_result();
				ReceiveBase(result, addOrUpdateCouponGroupSync_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.pms.data.service.SyncResult addOrUpdateCouponRuleSync(com.vip.pms.data.service.CouponRuleRequestModel couponRuleRequestModel_) {
				
				send_addOrUpdateCouponRuleSync(couponRuleRequestModel_);
				return recv_addOrUpdateCouponRuleSync(); 
				
			}
			
			
			private void send_addOrUpdateCouponRuleSync(com.vip.pms.data.service.CouponRuleRequestModel couponRuleRequestModel_){
				
				InitInvocation("addOrUpdateCouponRuleSync");
				
				addOrUpdateCouponRuleSync_args args = new addOrUpdateCouponRuleSync_args();
				args.SetCouponRuleRequestModel(couponRuleRequestModel_);
				
				SendBase(args, addOrUpdateCouponRuleSync_argsHelper.getInstance());
			}
			
			
			private com.vip.pms.data.service.SyncResult recv_addOrUpdateCouponRuleSync(){
				
				addOrUpdateCouponRuleSync_result result = new addOrUpdateCouponRuleSync_result();
				ReceiveBase(result, addOrUpdateCouponRuleSync_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.pms.data.service.SyncResult addOrUpdateCouponSync(com.vip.pms.data.service.CouponRequestModel couponRequestModel_) {
				
				send_addOrUpdateCouponSync(couponRequestModel_);
				return recv_addOrUpdateCouponSync(); 
				
			}
			
			
			private void send_addOrUpdateCouponSync(com.vip.pms.data.service.CouponRequestModel couponRequestModel_){
				
				InitInvocation("addOrUpdateCouponSync");
				
				addOrUpdateCouponSync_args args = new addOrUpdateCouponSync_args();
				args.SetCouponRequestModel(couponRequestModel_);
				
				SendBase(args, addOrUpdateCouponSync_argsHelper.getInstance());
			}
			
			
			private com.vip.pms.data.service.SyncResult recv_addOrUpdateCouponSync(){
				
				addOrUpdateCouponSync_result result = new addOrUpdateCouponSync_result();
				ReceiveBase(result, addOrUpdateCouponSync_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.pms.data.service.SyncResult addOrUpdatePaySync(com.vip.pms.data.service.PayRequestModel payRequestModel_) {
				
				send_addOrUpdatePaySync(payRequestModel_);
				return recv_addOrUpdatePaySync(); 
				
			}
			
			
			private void send_addOrUpdatePaySync(com.vip.pms.data.service.PayRequestModel payRequestModel_){
				
				InitInvocation("addOrUpdatePaySync");
				
				addOrUpdatePaySync_args args = new addOrUpdatePaySync_args();
				args.SetPayRequestModel(payRequestModel_);
				
				SendBase(args, addOrUpdatePaySync_argsHelper.getInstance());
			}
			
			
			private com.vip.pms.data.service.SyncResult recv_addOrUpdatePaySync(){
				
				addOrUpdatePaySync_result result = new addOrUpdatePaySync_result();
				ReceiveBase(result, addOrUpdatePaySync_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.pms.data.service.SyncResult addOrUpdatePrepayInfoSync(com.vip.pms.data.service.PrepayInfoRequestModel prepayInfoRequestModel_) {
				
				send_addOrUpdatePrepayInfoSync(prepayInfoRequestModel_);
				return recv_addOrUpdatePrepayInfoSync(); 
				
			}
			
			
			private void send_addOrUpdatePrepayInfoSync(com.vip.pms.data.service.PrepayInfoRequestModel prepayInfoRequestModel_){
				
				InitInvocation("addOrUpdatePrepayInfoSync");
				
				addOrUpdatePrepayInfoSync_args args = new addOrUpdatePrepayInfoSync_args();
				args.SetPrepayInfoRequestModel(prepayInfoRequestModel_);
				
				SendBase(args, addOrUpdatePrepayInfoSync_argsHelper.getInstance());
			}
			
			
			private com.vip.pms.data.service.SyncResult recv_addOrUpdatePrepayInfoSync(){
				
				addOrUpdatePrepayInfoSync_result result = new addOrUpdatePrepayInfoSync_result();
				ReceiveBase(result, addOrUpdatePrepayInfoSync_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.pms.data.service.SyncResult addOrUpdateSpecialSync(com.vip.pms.data.service.SpecialRequestModel specialRequestModel_) {
				
				send_addOrUpdateSpecialSync(specialRequestModel_);
				return recv_addOrUpdateSpecialSync(); 
				
			}
			
			
			private void send_addOrUpdateSpecialSync(com.vip.pms.data.service.SpecialRequestModel specialRequestModel_){
				
				InitInvocation("addOrUpdateSpecialSync");
				
				addOrUpdateSpecialSync_args args = new addOrUpdateSpecialSync_args();
				args.SetSpecialRequestModel(specialRequestModel_);
				
				SendBase(args, addOrUpdateSpecialSync_argsHelper.getInstance());
			}
			
			
			private com.vip.pms.data.service.SyncResult recv_addOrUpdateSpecialSync(){
				
				addOrUpdateSpecialSync_result result = new addOrUpdateSpecialSync_result();
				ReceiveBase(result, addOrUpdateSpecialSync_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public void addOrUpdateSurprisePriceActivitySync(com.vip.pms.data.service.SurprisePriceActivityRequestModel activityRequestModel_) {
				
				send_addOrUpdateSurprisePriceActivitySync(activityRequestModel_);
				recv_addOrUpdateSurprisePriceActivitySync();
				
			}
			
			
			private void send_addOrUpdateSurprisePriceActivitySync(com.vip.pms.data.service.SurprisePriceActivityRequestModel activityRequestModel_){
				
				InitInvocation("addOrUpdateSurprisePriceActivitySync");
				
				addOrUpdateSurprisePriceActivitySync_args args = new addOrUpdateSurprisePriceActivitySync_args();
				args.SetActivityRequestModel(activityRequestModel_);
				
				SendBase(args, addOrUpdateSurprisePriceActivitySync_argsHelper.getInstance());
			}
			
			
			private void recv_addOrUpdateSurprisePriceActivitySync(){
				
				addOrUpdateSurprisePriceActivitySync_result result = new addOrUpdateSurprisePriceActivitySync_result();
				ReceiveBase(result, addOrUpdateSurprisePriceActivitySync_resultHelper.getInstance());
				
				
			}
			
			
			public bool? addPayUserLog(com.vip.pms.data.service.PayUserLogRequestModel request_) {
				
				send_addPayUserLog(request_);
				return recv_addPayUserLog(); 
				
			}
			
			
			private void send_addPayUserLog(com.vip.pms.data.service.PayUserLogRequestModel request_){
				
				InitInvocation("addPayUserLog");
				
				addPayUserLog_args args = new addPayUserLog_args();
				args.SetRequest(request_);
				
				SendBase(args, addPayUserLog_argsHelper.getInstance());
			}
			
			
			private bool? recv_addPayUserLog(){
				
				addPayUserLog_result result = new addPayUserLog_result();
				ReceiveBase(result, addPayUserLog_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public bool? addSpecialUserLog(com.vip.pms.data.service.SpecialUserLogRequestModel request_) {
				
				send_addSpecialUserLog(request_);
				return recv_addSpecialUserLog(); 
				
			}
			
			
			private void send_addSpecialUserLog(com.vip.pms.data.service.SpecialUserLogRequestModel request_){
				
				InitInvocation("addSpecialUserLog");
				
				addSpecialUserLog_args args = new addSpecialUserLog_args();
				args.SetRequest(request_);
				
				SendBase(args, addSpecialUserLog_argsHelper.getInstance());
			}
			
			
			private bool? recv_addSpecialUserLog(){
				
				addSpecialUserLog_result result = new addSpecialUserLog_result();
				ReceiveBase(result, addSpecialUserLog_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.pms.data.service.SyncResult batchModifyCouponTime(List<com.vip.pms.data.service.ModifyInfoRequestModel> modifyList_,string taskId_) {
				
				send_batchModifyCouponTime(modifyList_,taskId_);
				return recv_batchModifyCouponTime(); 
				
			}
			
			
			private void send_batchModifyCouponTime(List<com.vip.pms.data.service.ModifyInfoRequestModel> modifyList_,string taskId_){
				
				InitInvocation("batchModifyCouponTime");
				
				batchModifyCouponTime_args args = new batchModifyCouponTime_args();
				args.SetModifyList(modifyList_);
				args.SetTaskId(taskId_);
				
				SendBase(args, batchModifyCouponTime_argsHelper.getInstance());
			}
			
			
			private com.vip.pms.data.service.SyncResult recv_batchModifyCouponTime(){
				
				batchModifyCouponTime_result result = new batchModifyCouponTime_result();
				ReceiveBase(result, batchModifyCouponTime_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public bool? buildAllActivityIndex(string indexType_) {
				
				send_buildAllActivityIndex(indexType_);
				return recv_buildAllActivityIndex(); 
				
			}
			
			
			private void send_buildAllActivityIndex(string indexType_){
				
				InitInvocation("buildAllActivityIndex");
				
				buildAllActivityIndex_args args = new buildAllActivityIndex_args();
				args.SetIndexType(indexType_);
				
				SendBase(args, buildAllActivityIndex_argsHelper.getInstance());
			}
			
			
			private bool? recv_buildAllActivityIndex(){
				
				buildAllActivityIndex_result result = new buildAllActivityIndex_result();
				ReceiveBase(result, buildAllActivityIndex_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.pms.data.service.SyncResult cancelActivitySync(List<string> actNoList_,long? channelId_) {
				
				send_cancelActivitySync(actNoList_,channelId_);
				return recv_cancelActivitySync(); 
				
			}
			
			
			private void send_cancelActivitySync(List<string> actNoList_,long? channelId_){
				
				InitInvocation("cancelActivitySync");
				
				cancelActivitySync_args args = new cancelActivitySync_args();
				args.SetActNoList(actNoList_);
				args.SetChannelId(channelId_);
				
				SendBase(args, cancelActivitySync_argsHelper.getInstance());
			}
			
			
			private com.vip.pms.data.service.SyncResult recv_cancelActivitySync(){
				
				cancelActivitySync_result result = new cancelActivitySync_result();
				ReceiveBase(result, cancelActivitySync_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.pms.data.service.SyncResult cancelCommandSync(List<string> commandNoList_) {
				
				send_cancelCommandSync(commandNoList_);
				return recv_cancelCommandSync(); 
				
			}
			
			
			private void send_cancelCommandSync(List<string> commandNoList_){
				
				InitInvocation("cancelCommandSync");
				
				cancelCommandSync_args args = new cancelCommandSync_args();
				args.SetCommandNoList(commandNoList_);
				
				SendBase(args, cancelCommandSync_argsHelper.getInstance());
			}
			
			
			private com.vip.pms.data.service.SyncResult recv_cancelCommandSync(){
				
				cancelCommandSync_result result = new cancelCommandSync_result();
				ReceiveBase(result, cancelCommandSync_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.pms.data.service.SyncResult cancelOrOfflineCouponGroupSync(List<string> noList_,bool isCancel_) {
				
				send_cancelOrOfflineCouponGroupSync(noList_,isCancel_);
				return recv_cancelOrOfflineCouponGroupSync(); 
				
			}
			
			
			private void send_cancelOrOfflineCouponGroupSync(List<string> noList_,bool isCancel_){
				
				InitInvocation("cancelOrOfflineCouponGroupSync");
				
				cancelOrOfflineCouponGroupSync_args args = new cancelOrOfflineCouponGroupSync_args();
				args.SetNoList(noList_);
				args.SetIsCancel(isCancel_);
				
				SendBase(args, cancelOrOfflineCouponGroupSync_argsHelper.getInstance());
			}
			
			
			private com.vip.pms.data.service.SyncResult recv_cancelOrOfflineCouponGroupSync(){
				
				cancelOrOfflineCouponGroupSync_result result = new cancelOrOfflineCouponGroupSync_result();
				ReceiveBase(result, cancelOrOfflineCouponGroupSync_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.pms.data.service.SyncResult cancelOrOfflineCouponRuleSync(List<string> noList_,bool isCancel_) {
				
				send_cancelOrOfflineCouponRuleSync(noList_,isCancel_);
				return recv_cancelOrOfflineCouponRuleSync(); 
				
			}
			
			
			private void send_cancelOrOfflineCouponRuleSync(List<string> noList_,bool isCancel_){
				
				InitInvocation("cancelOrOfflineCouponRuleSync");
				
				cancelOrOfflineCouponRuleSync_args args = new cancelOrOfflineCouponRuleSync_args();
				args.SetNoList(noList_);
				args.SetIsCancel(isCancel_);
				
				SendBase(args, cancelOrOfflineCouponRuleSync_argsHelper.getInstance());
			}
			
			
			private com.vip.pms.data.service.SyncResult recv_cancelOrOfflineCouponRuleSync(){
				
				cancelOrOfflineCouponRuleSync_result result = new cancelOrOfflineCouponRuleSync_result();
				ReceiveBase(result, cancelOrOfflineCouponRuleSync_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.pms.data.service.SyncResult cancelOrOfflineCouponSync(List<string> noList_,bool isCancel_) {
				
				send_cancelOrOfflineCouponSync(noList_,isCancel_);
				return recv_cancelOrOfflineCouponSync(); 
				
			}
			
			
			private void send_cancelOrOfflineCouponSync(List<string> noList_,bool isCancel_){
				
				InitInvocation("cancelOrOfflineCouponSync");
				
				cancelOrOfflineCouponSync_args args = new cancelOrOfflineCouponSync_args();
				args.SetNoList(noList_);
				args.SetIsCancel(isCancel_);
				
				SendBase(args, cancelOrOfflineCouponSync_argsHelper.getInstance());
			}
			
			
			private com.vip.pms.data.service.SyncResult recv_cancelOrOfflineCouponSync(){
				
				cancelOrOfflineCouponSync_result result = new cancelOrOfflineCouponSync_result();
				ReceiveBase(result, cancelOrOfflineCouponSync_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public bool? cancelOrder(string orderNo_,byte refIdType_,List<long?> refIdList_,long? userId_) {
				
				send_cancelOrder(orderNo_,refIdType_,refIdList_,userId_);
				return recv_cancelOrder(); 
				
			}
			
			
			private void send_cancelOrder(string orderNo_,byte refIdType_,List<long?> refIdList_,long? userId_){
				
				InitInvocation("cancelOrder");
				
				cancelOrder_args args = new cancelOrder_args();
				args.SetOrderNo(orderNo_);
				args.SetRefIdType(refIdType_);
				args.SetRefIdList(refIdList_);
				args.SetUserId(userId_);
				
				SendBase(args, cancelOrder_argsHelper.getInstance());
			}
			
			
			private bool? recv_cancelOrder(){
				
				cancelOrder_result result = new cancelOrder_result();
				ReceiveBase(result, cancelOrder_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.pms.data.service.SyncResult cancelPaySync(List<string> payNoList_) {
				
				send_cancelPaySync(payNoList_);
				return recv_cancelPaySync(); 
				
			}
			
			
			private void send_cancelPaySync(List<string> payNoList_){
				
				InitInvocation("cancelPaySync");
				
				cancelPaySync_args args = new cancelPaySync_args();
				args.SetPayNoList(payNoList_);
				
				SendBase(args, cancelPaySync_argsHelper.getInstance());
			}
			
			
			private com.vip.pms.data.service.SyncResult recv_cancelPaySync(){
				
				cancelPaySync_result result = new cancelPaySync_result();
				ReceiveBase(result, cancelPaySync_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.pms.data.service.SyncResult cancelSpecialSync(List<string> specialNoList_) {
				
				send_cancelSpecialSync(specialNoList_);
				return recv_cancelSpecialSync(); 
				
			}
			
			
			private void send_cancelSpecialSync(List<string> specialNoList_){
				
				InitInvocation("cancelSpecialSync");
				
				cancelSpecialSync_args args = new cancelSpecialSync_args();
				args.SetSpecialNoList(specialNoList_);
				
				SendBase(args, cancelSpecialSync_argsHelper.getInstance());
			}
			
			
			private com.vip.pms.data.service.SyncResult recv_cancelSpecialSync(){
				
				cancelSpecialSync_result result = new cancelSpecialSync_result();
				ReceiveBase(result, cancelSpecialSync_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public void cancelSurprisePriceActivitySync(List<string> actNoList_) {
				
				send_cancelSurprisePriceActivitySync(actNoList_);
				recv_cancelSurprisePriceActivitySync();
				
			}
			
			
			private void send_cancelSurprisePriceActivitySync(List<string> actNoList_){
				
				InitInvocation("cancelSurprisePriceActivitySync");
				
				cancelSurprisePriceActivitySync_args args = new cancelSurprisePriceActivitySync_args();
				args.SetActNoList(actNoList_);
				
				SendBase(args, cancelSurprisePriceActivitySync_argsHelper.getInstance());
			}
			
			
			private void recv_cancelSurprisePriceActivitySync(){
				
				cancelSurprisePriceActivitySync_result result = new cancelSurprisePriceActivitySync_result();
				ReceiveBase(result, cancelSurprisePriceActivitySync_resultHelper.getInstance());
				
				
			}
			
			
			public com.vip.pms.data.service.CheckResult check(com.vip.pms.data.service.CheckRequest checkRequest_) {
				
				send_check(checkRequest_);
				return recv_check(); 
				
			}
			
			
			private void send_check(com.vip.pms.data.service.CheckRequest checkRequest_){
				
				InitInvocation("check");
				
				check_args args = new check_args();
				args.SetCheckRequest(checkRequest_);
				
				SendBase(args, check_argsHelper.getInstance());
			}
			
			
			private com.vip.pms.data.service.CheckResult recv_check(){
				
				check_result result = new check_result();
				ReceiveBase(result, check_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.pms.data.service.CouponResResult couponActivate(com.vip.pms.data.service.CouponInstanceModel instanceModel_) {
				
				send_couponActivate(instanceModel_);
				return recv_couponActivate(); 
				
			}
			
			
			private void send_couponActivate(com.vip.pms.data.service.CouponInstanceModel instanceModel_){
				
				InitInvocation("couponActivate");
				
				couponActivate_args args = new couponActivate_args();
				args.SetInstanceModel(instanceModel_);
				
				SendBase(args, couponActivate_argsHelper.getInstance());
			}
			
			
			private com.vip.pms.data.service.CouponResResult recv_couponActivate(){
				
				couponActivate_result result = new couponActivate_result();
				ReceiveBase(result, couponActivate_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.pms.data.service.CouponResResult couponBind(com.vip.pms.data.service.CouponInstanceModel instanceModel_) {
				
				send_couponBind(instanceModel_);
				return recv_couponBind(); 
				
			}
			
			
			private void send_couponBind(com.vip.pms.data.service.CouponInstanceModel instanceModel_){
				
				InitInvocation("couponBind");
				
				couponBind_args args = new couponBind_args();
				args.SetInstanceModel(instanceModel_);
				
				SendBase(args, couponBind_argsHelper.getInstance());
			}
			
			
			private com.vip.pms.data.service.CouponResResult recv_couponBind(){
				
				couponBind_result result = new couponBind_result();
				ReceiveBase(result, couponBind_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.pms.data.service.CouponResResult couponGroupActivate(com.vip.pms.data.service.CouponInstanceModel groupInstanceModel_,List<com.vip.pms.data.service.CouponInstanceModel> couponInstanceList_) {
				
				send_couponGroupActivate(groupInstanceModel_,couponInstanceList_);
				return recv_couponGroupActivate(); 
				
			}
			
			
			private void send_couponGroupActivate(com.vip.pms.data.service.CouponInstanceModel groupInstanceModel_,List<com.vip.pms.data.service.CouponInstanceModel> couponInstanceList_){
				
				InitInvocation("couponGroupActivate");
				
				couponGroupActivate_args args = new couponGroupActivate_args();
				args.SetGroupInstanceModel(groupInstanceModel_);
				args.SetCouponInstanceList(couponInstanceList_);
				
				SendBase(args, couponGroupActivate_argsHelper.getInstance());
			}
			
			
			private com.vip.pms.data.service.CouponResResult recv_couponGroupActivate(){
				
				couponGroupActivate_result result = new couponGroupActivate_result();
				ReceiveBase(result, couponGroupActivate_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.pms.data.service.CouponResResult couponGroupBind(com.vip.pms.data.service.CouponInstanceModel groupInstanceModel_,List<com.vip.pms.data.service.CouponInstanceModel> couponInstanceList_) {
				
				send_couponGroupBind(groupInstanceModel_,couponInstanceList_);
				return recv_couponGroupBind(); 
				
			}
			
			
			private void send_couponGroupBind(com.vip.pms.data.service.CouponInstanceModel groupInstanceModel_,List<com.vip.pms.data.service.CouponInstanceModel> couponInstanceList_){
				
				InitInvocation("couponGroupBind");
				
				couponGroupBind_args args = new couponGroupBind_args();
				args.SetGroupInstanceModel(groupInstanceModel_);
				args.SetCouponInstanceList(couponInstanceList_);
				
				SendBase(args, couponGroupBind_argsHelper.getInstance());
			}
			
			
			private com.vip.pms.data.service.CouponResResult recv_couponGroupBind(){
				
				couponGroupBind_result result = new couponGroupBind_result();
				ReceiveBase(result, couponGroupBind_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public void delGoodsOriginalPrice(List<string> spuIdList_) {
				
				send_delGoodsOriginalPrice(spuIdList_);
				recv_delGoodsOriginalPrice();
				
			}
			
			
			private void send_delGoodsOriginalPrice(List<string> spuIdList_){
				
				InitInvocation("delGoodsOriginalPrice");
				
				delGoodsOriginalPrice_args args = new delGoodsOriginalPrice_args();
				args.SetSpuIdList(spuIdList_);
				
				SendBase(args, delGoodsOriginalPrice_argsHelper.getInstance());
			}
			
			
			private void recv_delGoodsOriginalPrice(){
				
				delGoodsOriginalPrice_result result = new delGoodsOriginalPrice_result();
				ReceiveBase(result, delGoodsOriginalPrice_resultHelper.getInstance());
				
				
			}
			
			
			public void delGoodsSurprisePrice(List<com.vip.pms.data.service.FlushGoodsSurprisePriceModel> modelList_) {
				
				send_delGoodsSurprisePrice(modelList_);
				recv_delGoodsSurprisePrice();
				
			}
			
			
			private void send_delGoodsSurprisePrice(List<com.vip.pms.data.service.FlushGoodsSurprisePriceModel> modelList_){
				
				InitInvocation("delGoodsSurprisePrice");
				
				delGoodsSurprisePrice_args args = new delGoodsSurprisePrice_args();
				args.SetModelList(modelList_);
				
				SendBase(args, delGoodsSurprisePrice_argsHelper.getInstance());
			}
			
			
			private void recv_delGoodsSurprisePrice(){
				
				delGoodsSurprisePrice_result result = new delGoodsSurprisePrice_result();
				ReceiveBase(result, delGoodsSurprisePrice_resultHelper.getInstance());
				
				
			}
			
			
			public bool? deleteConfig(string type_,string key_) {
				
				send_deleteConfig(type_,key_);
				return recv_deleteConfig(); 
				
			}
			
			
			private void send_deleteConfig(string type_,string key_){
				
				InitInvocation("deleteConfig");
				
				deleteConfig_args args = new deleteConfig_args();
				args.SetType(type_);
				args.SetKey(key_);
				
				SendBase(args, deleteConfig_argsHelper.getInstance());
			}
			
			
			private bool? recv_deleteConfig(){
				
				deleteConfig_result result = new deleteConfig_result();
				ReceiveBase(result, deleteConfig_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.pms.data.service.SyncResult deletePrepayInfoByMidSync(string prepayMainNo_,List<long?> merchandiseNos_) {
				
				send_deletePrepayInfoByMidSync(prepayMainNo_,merchandiseNos_);
				return recv_deletePrepayInfoByMidSync(); 
				
			}
			
			
			private void send_deletePrepayInfoByMidSync(string prepayMainNo_,List<long?> merchandiseNos_){
				
				InitInvocation("deletePrepayInfoByMidSync");
				
				deletePrepayInfoByMidSync_args args = new deletePrepayInfoByMidSync_args();
				args.SetPrepayMainNo(prepayMainNo_);
				args.SetMerchandiseNos(merchandiseNos_);
				
				SendBase(args, deletePrepayInfoByMidSync_argsHelper.getInstance());
			}
			
			
			private com.vip.pms.data.service.SyncResult recv_deletePrepayInfoByMidSync(){
				
				deletePrepayInfoByMidSync_result result = new deletePrepayInfoByMidSync_result();
				ReceiveBase(result, deletePrepayInfoByMidSync_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.pms.data.service.SyncResult deletePrepayInfoSync(List<string> prepayMainNos_) {
				
				send_deletePrepayInfoSync(prepayMainNos_);
				return recv_deletePrepayInfoSync(); 
				
			}
			
			
			private void send_deletePrepayInfoSync(List<string> prepayMainNos_){
				
				InitInvocation("deletePrepayInfoSync");
				
				deletePrepayInfoSync_args args = new deletePrepayInfoSync_args();
				args.SetPrepayMainNos(prepayMainNos_);
				
				SendBase(args, deletePrepayInfoSync_argsHelper.getInstance());
			}
			
			
			private com.vip.pms.data.service.SyncResult recv_deletePrepayInfoSync(){
				
				deletePrepayInfoSync_result result = new deletePrepayInfoSync_result();
				ReceiveBase(result, deletePrepayInfoSync_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.pms.data.service.ExportRespModel> exportCoupon(string couponNo_,long offset_) {
				
				send_exportCoupon(couponNo_,offset_);
				return recv_exportCoupon(); 
				
			}
			
			
			private void send_exportCoupon(string couponNo_,long offset_){
				
				InitInvocation("exportCoupon");
				
				exportCoupon_args args = new exportCoupon_args();
				args.SetCouponNo(couponNo_);
				args.SetOffset(offset_);
				
				SendBase(args, exportCoupon_argsHelper.getInstance());
			}
			
			
			private List<com.vip.pms.data.service.ExportRespModel> recv_exportCoupon(){
				
				exportCoupon_result result = new exportCoupon_result();
				ReceiveBase(result, exportCoupon_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.pms.data.service.ExportRespModel> exportCouponGroup(string groupNo_,long offset_) {
				
				send_exportCouponGroup(groupNo_,offset_);
				return recv_exportCouponGroup(); 
				
			}
			
			
			private void send_exportCouponGroup(string groupNo_,long offset_){
				
				InitInvocation("exportCouponGroup");
				
				exportCouponGroup_args args = new exportCouponGroup_args();
				args.SetGroupNo(groupNo_);
				args.SetOffset(offset_);
				
				SendBase(args, exportCouponGroup_argsHelper.getInstance());
			}
			
			
			private List<com.vip.pms.data.service.ExportRespModel> recv_exportCouponGroup(){
				
				exportCouponGroup_result result = new exportCouponGroup_result();
				ReceiveBase(result, exportCouponGroup_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.pms.data.service.OrderNosResult fetchCommandOrderNos(com.vip.pms.data.service.FetchCommandOrderNosRequestModel fetchCommandOrderNosRequestModel_) {
				
				send_fetchCommandOrderNos(fetchCommandOrderNosRequestModel_);
				return recv_fetchCommandOrderNos(); 
				
			}
			
			
			private void send_fetchCommandOrderNos(com.vip.pms.data.service.FetchCommandOrderNosRequestModel fetchCommandOrderNosRequestModel_){
				
				InitInvocation("fetchCommandOrderNos");
				
				fetchCommandOrderNos_args args = new fetchCommandOrderNos_args();
				args.SetFetchCommandOrderNosRequestModel(fetchCommandOrderNosRequestModel_);
				
				SendBase(args, fetchCommandOrderNos_argsHelper.getInstance());
			}
			
			
			private com.vip.pms.data.service.OrderNosResult recv_fetchCommandOrderNos(){
				
				fetchCommandOrderNos_result result = new fetchCommandOrderNos_result();
				ReceiveBase(result, fetchCommandOrderNos_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.pms.data.service.OrderResult fetchOrder(com.vip.pms.data.service.FetchOrderRequestModel fetchOrderRequestModel_) {
				
				send_fetchOrder(fetchOrderRequestModel_);
				return recv_fetchOrder(); 
				
			}
			
			
			private void send_fetchOrder(com.vip.pms.data.service.FetchOrderRequestModel fetchOrderRequestModel_){
				
				InitInvocation("fetchOrder");
				
				fetchOrder_args args = new fetchOrder_args();
				args.SetFetchOrderRequestModel(fetchOrderRequestModel_);
				
				SendBase(args, fetchOrder_argsHelper.getInstance());
			}
			
			
			private com.vip.pms.data.service.OrderResult recv_fetchOrder(){
				
				fetchOrder_result result = new fetchOrder_result();
				ReceiveBase(result, fetchOrder_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.pms.data.service.SyncResult flushCouponRuleIndexSync() {
				
				send_flushCouponRuleIndexSync();
				return recv_flushCouponRuleIndexSync(); 
				
			}
			
			
			private void send_flushCouponRuleIndexSync(){
				
				InitInvocation("flushCouponRuleIndexSync");
				
				flushCouponRuleIndexSync_args args = new flushCouponRuleIndexSync_args();
				
				SendBase(args, flushCouponRuleIndexSync_argsHelper.getInstance());
			}
			
			
			private com.vip.pms.data.service.SyncResult recv_flushCouponRuleIndexSync(){
				
				flushCouponRuleIndexSync_result result = new flushCouponRuleIndexSync_result();
				ReceiveBase(result, flushCouponRuleIndexSync_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public void flushGoodsOriginalPrice(List<com.vip.pms.data.service.FlushGoodsOriginalPriceModel> modelList_) {
				
				send_flushGoodsOriginalPrice(modelList_);
				recv_flushGoodsOriginalPrice();
				
			}
			
			
			private void send_flushGoodsOriginalPrice(List<com.vip.pms.data.service.FlushGoodsOriginalPriceModel> modelList_){
				
				InitInvocation("flushGoodsOriginalPrice");
				
				flushGoodsOriginalPrice_args args = new flushGoodsOriginalPrice_args();
				args.SetModelList(modelList_);
				
				SendBase(args, flushGoodsOriginalPrice_argsHelper.getInstance());
			}
			
			
			private void recv_flushGoodsOriginalPrice(){
				
				flushGoodsOriginalPrice_result result = new flushGoodsOriginalPrice_result();
				ReceiveBase(result, flushGoodsOriginalPrice_resultHelper.getInstance());
				
				
			}
			
			
			public void flushGoodsSurprisePrice(List<com.vip.pms.data.service.FlushGoodsSurprisePriceModel> modelList_) {
				
				send_flushGoodsSurprisePrice(modelList_);
				recv_flushGoodsSurprisePrice();
				
			}
			
			
			private void send_flushGoodsSurprisePrice(List<com.vip.pms.data.service.FlushGoodsSurprisePriceModel> modelList_){
				
				InitInvocation("flushGoodsSurprisePrice");
				
				flushGoodsSurprisePrice_args args = new flushGoodsSurprisePrice_args();
				args.SetModelList(modelList_);
				
				SendBase(args, flushGoodsSurprisePrice_argsHelper.getInstance());
			}
			
			
			private void recv_flushGoodsSurprisePrice(){
				
				flushGoodsSurprisePrice_result result = new flushGoodsSurprisePrice_result();
				ReceiveBase(result, flushGoodsSurprisePrice_resultHelper.getInstance());
				
				
			}
			
			
			public List<com.vip.pms.data.service.AdminConfigModel> getConfig(string type_,string key_) {
				
				send_getConfig(type_,key_);
				return recv_getConfig(); 
				
			}
			
			
			private void send_getConfig(string type_,string key_){
				
				InitInvocation("getConfig");
				
				getConfig_args args = new getConfig_args();
				args.SetType(type_);
				args.SetKey(key_);
				
				SendBase(args, getConfig_argsHelper.getInstance());
			}
			
			
			private List<com.vip.pms.data.service.AdminConfigModel> recv_getConfig(){
				
				getConfig_result result = new getConfig_result();
				ReceiveBase(result, getConfig_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.pms.data.service.AdminConfigModel> getTypeConfig(string type_) {
				
				send_getTypeConfig(type_);
				return recv_getTypeConfig(); 
				
			}
			
			
			private void send_getTypeConfig(string type_){
				
				InitInvocation("getTypeConfig");
				
				getTypeConfig_args args = new getTypeConfig_args();
				args.SetType(type_);
				
				SendBase(args, getTypeConfig_argsHelper.getInstance());
			}
			
			
			private List<com.vip.pms.data.service.AdminConfigModel> recv_getTypeConfig(){
				
				getTypeConfig_result result = new getTypeConfig_result();
				ReceiveBase(result, getTypeConfig_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.hermes.core.health.CheckResult healthCheck() {
				
				send_healthCheck();
				return recv_healthCheck(); 
				
			}
			
			
			private void send_healthCheck(){
				
				InitInvocation("healthCheck");
				
				healthCheck_args args = new healthCheck_args();
				
				SendBase(args, healthCheck_argsHelper.getInstance());
			}
			
			
			private com.vip.hermes.core.health.CheckResult recv_healthCheck(){
				
				healthCheck_result result = new healthCheck_result();
				ReceiveBase(result, healthCheck_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public bool? modifyCacheSwitchStatus(com.vip.pms.data.enums.SwitchStatus? switchStatus_) {
				
				send_modifyCacheSwitchStatus(switchStatus_);
				return recv_modifyCacheSwitchStatus(); 
				
			}
			
			
			private void send_modifyCacheSwitchStatus(com.vip.pms.data.enums.SwitchStatus? switchStatus_){
				
				InitInvocation("modifyCacheSwitchStatus");
				
				modifyCacheSwitchStatus_args args = new modifyCacheSwitchStatus_args();
				args.SetSwitchStatus(switchStatus_);
				
				SendBase(args, modifyCacheSwitchStatus_argsHelper.getInstance());
			}
			
			
			private bool? recv_modifyCacheSwitchStatus(){
				
				modifyCacheSwitchStatus_result result = new modifyCacheSwitchStatus_result();
				ReceiveBase(result, modifyCacheSwitchStatus_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.pms.data.service.SyncResult modifyCouponTime(int couponId_,long beginTime_,long endTime_,string taskId_) {
				
				send_modifyCouponTime(couponId_,beginTime_,endTime_,taskId_);
				return recv_modifyCouponTime(); 
				
			}
			
			
			private void send_modifyCouponTime(int couponId_,long beginTime_,long endTime_,string taskId_){
				
				InitInvocation("modifyCouponTime");
				
				modifyCouponTime_args args = new modifyCouponTime_args();
				args.SetCouponId(couponId_);
				args.SetBeginTime(beginTime_);
				args.SetEndTime(endTime_);
				args.SetTaskId(taskId_);
				
				SendBase(args, modifyCouponTime_argsHelper.getInstance());
			}
			
			
			private com.vip.pms.data.service.SyncResult recv_modifyCouponTime(){
				
				modifyCouponTime_result result = new modifyCouponTime_result();
				ReceiveBase(result, modifyCouponTime_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.pms.data.service.SyncResult modifyCouponTimeByUserIds(int couponId_,long beginTime_,long endTime_,List<string> userIds_) {
				
				send_modifyCouponTimeByUserIds(couponId_,beginTime_,endTime_,userIds_);
				return recv_modifyCouponTimeByUserIds(); 
				
			}
			
			
			private void send_modifyCouponTimeByUserIds(int couponId_,long beginTime_,long endTime_,List<string> userIds_){
				
				InitInvocation("modifyCouponTimeByUserIds");
				
				modifyCouponTimeByUserIds_args args = new modifyCouponTimeByUserIds_args();
				args.SetCouponId(couponId_);
				args.SetBeginTime(beginTime_);
				args.SetEndTime(endTime_);
				args.SetUserIds(userIds_);
				
				SendBase(args, modifyCouponTimeByUserIds_argsHelper.getInstance());
			}
			
			
			private com.vip.pms.data.service.SyncResult recv_modifyCouponTimeByUserIds(){
				
				modifyCouponTimeByUserIds_result result = new modifyCouponTimeByUserIds_result();
				ReceiveBase(result, modifyCouponTimeByUserIds_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.pms.data.coupon.model.CouponMultiBindResponse> multiBind(com.vip.pms.data.coupon.model.CouponMultiBindRequest multiBindRequest_) {
				
				send_multiBind(multiBindRequest_);
				return recv_multiBind(); 
				
			}
			
			
			private void send_multiBind(com.vip.pms.data.coupon.model.CouponMultiBindRequest multiBindRequest_){
				
				InitInvocation("multiBind");
				
				multiBind_args args = new multiBind_args();
				args.SetMultiBindRequest(multiBindRequest_);
				
				SendBase(args, multiBind_argsHelper.getInstance());
			}
			
			
			private List<com.vip.pms.data.coupon.model.CouponMultiBindResponse> recv_multiBind(){
				
				multiBind_result result = new multiBind_result();
				ReceiveBase(result, multiBind_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.pms.data.coupon.model.CouponMultiBindResponse> multiBindSyncMode(com.vip.pms.data.coupon.model.CouponMultiBindRequest multiBindRequest_) {
				
				send_multiBindSyncMode(multiBindRequest_);
				return recv_multiBindSyncMode(); 
				
			}
			
			
			private void send_multiBindSyncMode(com.vip.pms.data.coupon.model.CouponMultiBindRequest multiBindRequest_){
				
				InitInvocation("multiBindSyncMode");
				
				multiBindSyncMode_args args = new multiBindSyncMode_args();
				args.SetMultiBindRequest(multiBindRequest_);
				
				SendBase(args, multiBindSyncMode_argsHelper.getInstance());
			}
			
			
			private List<com.vip.pms.data.coupon.model.CouponMultiBindResponse> recv_multiBindSyncMode(){
				
				multiBindSyncMode_result result = new multiBindSyncMode_result();
				ReceiveBase(result, multiBindSyncMode_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public bool? offlineActivityCallback(List<string> actNoList_) {
				
				send_offlineActivityCallback(actNoList_);
				return recv_offlineActivityCallback(); 
				
			}
			
			
			private void send_offlineActivityCallback(List<string> actNoList_){
				
				InitInvocation("offlineActivityCallback");
				
				offlineActivityCallback_args args = new offlineActivityCallback_args();
				args.SetActNoList(actNoList_);
				
				SendBase(args, offlineActivityCallback_argsHelper.getInstance());
			}
			
			
			private bool? recv_offlineActivityCallback(){
				
				offlineActivityCallback_result result = new offlineActivityCallback_result();
				ReceiveBase(result, offlineActivityCallback_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.pms.data.service.SyncResult offlineActivitySync(List<string> actNoList_,long? channelId_) {
				
				send_offlineActivitySync(actNoList_,channelId_);
				return recv_offlineActivitySync(); 
				
			}
			
			
			private void send_offlineActivitySync(List<string> actNoList_,long? channelId_){
				
				InitInvocation("offlineActivitySync");
				
				offlineActivitySync_args args = new offlineActivitySync_args();
				args.SetActNoList(actNoList_);
				args.SetChannelId(channelId_);
				
				SendBase(args, offlineActivitySync_argsHelper.getInstance());
			}
			
			
			private com.vip.pms.data.service.SyncResult recv_offlineActivitySync(){
				
				offlineActivitySync_result result = new offlineActivitySync_result();
				ReceiveBase(result, offlineActivitySync_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.pms.data.service.SyncResult offlineCommandSync(List<string> commandNoList_) {
				
				send_offlineCommandSync(commandNoList_);
				return recv_offlineCommandSync(); 
				
			}
			
			
			private void send_offlineCommandSync(List<string> commandNoList_){
				
				InitInvocation("offlineCommandSync");
				
				offlineCommandSync_args args = new offlineCommandSync_args();
				args.SetCommandNoList(commandNoList_);
				
				SendBase(args, offlineCommandSync_argsHelper.getInstance());
			}
			
			
			private com.vip.pms.data.service.SyncResult recv_offlineCommandSync(){
				
				offlineCommandSync_result result = new offlineCommandSync_result();
				ReceiveBase(result, offlineCommandSync_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.pms.data.service.SyncResult offlinePaySync(List<string> payNoList_) {
				
				send_offlinePaySync(payNoList_);
				return recv_offlinePaySync(); 
				
			}
			
			
			private void send_offlinePaySync(List<string> payNoList_){
				
				InitInvocation("offlinePaySync");
				
				offlinePaySync_args args = new offlinePaySync_args();
				args.SetPayNoList(payNoList_);
				
				SendBase(args, offlinePaySync_argsHelper.getInstance());
			}
			
			
			private com.vip.pms.data.service.SyncResult recv_offlinePaySync(){
				
				offlinePaySync_result result = new offlinePaySync_result();
				ReceiveBase(result, offlinePaySync_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.pms.data.service.SyncResult offlinePrepayInfoSync(com.vip.pms.data.service.DeletePrepayInfoModel requestModel_) {
				
				send_offlinePrepayInfoSync(requestModel_);
				return recv_offlinePrepayInfoSync(); 
				
			}
			
			
			private void send_offlinePrepayInfoSync(com.vip.pms.data.service.DeletePrepayInfoModel requestModel_){
				
				InitInvocation("offlinePrepayInfoSync");
				
				offlinePrepayInfoSync_args args = new offlinePrepayInfoSync_args();
				args.SetRequestModel(requestModel_);
				
				SendBase(args, offlinePrepayInfoSync_argsHelper.getInstance());
			}
			
			
			private com.vip.pms.data.service.SyncResult recv_offlinePrepayInfoSync(){
				
				offlinePrepayInfoSync_result result = new offlinePrepayInfoSync_result();
				ReceiveBase(result, offlinePrepayInfoSync_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.pms.data.service.SyncResult offlineSpecialSync(List<string> specialNoList_) {
				
				send_offlineSpecialSync(specialNoList_);
				return recv_offlineSpecialSync(); 
				
			}
			
			
			private void send_offlineSpecialSync(List<string> specialNoList_){
				
				InitInvocation("offlineSpecialSync");
				
				offlineSpecialSync_args args = new offlineSpecialSync_args();
				args.SetSpecialNoList(specialNoList_);
				
				SendBase(args, offlineSpecialSync_argsHelper.getInstance());
			}
			
			
			private com.vip.pms.data.service.SyncResult recv_offlineSpecialSync(){
				
				offlineSpecialSync_result result = new offlineSpecialSync_result();
				ReceiveBase(result, offlineSpecialSync_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public void offlineSurprisePriceActivitySync(List<string> actNoList_) {
				
				send_offlineSurprisePriceActivitySync(actNoList_);
				recv_offlineSurprisePriceActivitySync();
				
			}
			
			
			private void send_offlineSurprisePriceActivitySync(List<string> actNoList_){
				
				InitInvocation("offlineSurprisePriceActivitySync");
				
				offlineSurprisePriceActivitySync_args args = new offlineSurprisePriceActivitySync_args();
				args.SetActNoList(actNoList_);
				
				SendBase(args, offlineSurprisePriceActivitySync_argsHelper.getInstance());
			}
			
			
			private void recv_offlineSurprisePriceActivitySync(){
				
				offlineSurprisePriceActivitySync_result result = new offlineSurprisePriceActivitySync_result();
				ReceiveBase(result, offlineSurprisePriceActivitySync_resultHelper.getInstance());
				
				
			}
			
			
			public com.vip.pms.data.model.sync.PrepareActivityResult prepareActivity(com.vip.pms.data.model.sync.PrepareActivityRequest request_) {
				
				send_prepareActivity(request_);
				return recv_prepareActivity(); 
				
			}
			
			
			private void send_prepareActivity(com.vip.pms.data.model.sync.PrepareActivityRequest request_){
				
				InitInvocation("prepareActivity");
				
				prepareActivity_args args = new prepareActivity_args();
				args.SetRequest(request_);
				
				SendBase(args, prepareActivity_argsHelper.getInstance());
			}
			
			
			private com.vip.pms.data.model.sync.PrepareActivityResult recv_prepareActivity(){
				
				prepareActivity_result result = new prepareActivity_result();
				ReceiveBase(result, prepareActivity_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.pms.data.model.sync.PrepareActivityResult prepareSpecial(com.vip.pms.data.model.sync.PrepareActivityRequest request_) {
				
				send_prepareSpecial(request_);
				return recv_prepareSpecial(); 
				
			}
			
			
			private void send_prepareSpecial(com.vip.pms.data.model.sync.PrepareActivityRequest request_){
				
				InitInvocation("prepareSpecial");
				
				prepareSpecial_args args = new prepareSpecial_args();
				args.SetRequest(request_);
				
				SendBase(args, prepareSpecial_argsHelper.getInstance());
			}
			
			
			private com.vip.pms.data.model.sync.PrepareActivityResult recv_prepareSpecial(){
				
				prepareSpecial_result result = new prepareSpecial_result();
				ReceiveBase(result, prepareSpecial_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public bool? publishRollbackUseCouponMsg(com.vip.pms.data.service.RollbackCouponReqModel reqModel_) {
				
				send_publishRollbackUseCouponMsg(reqModel_);
				return recv_publishRollbackUseCouponMsg(); 
				
			}
			
			
			private void send_publishRollbackUseCouponMsg(com.vip.pms.data.service.RollbackCouponReqModel reqModel_){
				
				InitInvocation("publishRollbackUseCouponMsg");
				
				publishRollbackUseCouponMsg_args args = new publishRollbackUseCouponMsg_args();
				args.SetReqModel(reqModel_);
				
				SendBase(args, publishRollbackUseCouponMsg_argsHelper.getInstance());
			}
			
			
			private bool? recv_publishRollbackUseCouponMsg(){
				
				publishRollbackUseCouponMsg_result result = new publishRollbackUseCouponMsg_result();
				ReceiveBase(result, publishRollbackUseCouponMsg_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.pms.data.service.SyncResult pushOfflineActivities(com.vip.pms.data.service.ActivityRequestModel activityRequestModel_,Dictionary<string, byte?> subActivityStatus_) {
				
				send_pushOfflineActivities(activityRequestModel_,subActivityStatus_);
				return recv_pushOfflineActivities(); 
				
			}
			
			
			private void send_pushOfflineActivities(com.vip.pms.data.service.ActivityRequestModel activityRequestModel_,Dictionary<string, byte?> subActivityStatus_){
				
				InitInvocation("pushOfflineActivities");
				
				pushOfflineActivities_args args = new pushOfflineActivities_args();
				args.SetActivityRequestModel(activityRequestModel_);
				args.SetSubActivityStatus(subActivityStatus_);
				
				SendBase(args, pushOfflineActivities_argsHelper.getInstance());
			}
			
			
			private com.vip.pms.data.service.SyncResult recv_pushOfflineActivities(){
				
				pushOfflineActivities_result result = new pushOfflineActivities_result();
				ReceiveBase(result, pushOfflineActivities_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.pms.data.service.ConfirmationResult> queryConfirmationNo(List<com.vip.pms.data.service.ConfirmationRequest> confirmationRequests_) {
				
				send_queryConfirmationNo(confirmationRequests_);
				return recv_queryConfirmationNo(); 
				
			}
			
			
			private void send_queryConfirmationNo(List<com.vip.pms.data.service.ConfirmationRequest> confirmationRequests_){
				
				InitInvocation("queryConfirmationNo");
				
				queryConfirmationNo_args args = new queryConfirmationNo_args();
				args.SetConfirmationRequests(confirmationRequests_);
				
				SendBase(args, queryConfirmationNo_argsHelper.getInstance());
			}
			
			
			private List<com.vip.pms.data.service.ConfirmationResult> recv_queryConfirmationNo(){
				
				queryConfirmationNo_result result = new queryConfirmationNo_result();
				ReceiveBase(result, queryConfirmationNo_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.pms.data.service.CouponInstanceStatResponse> queryCouponInstanceStat(List<string> couponNos_) {
				
				send_queryCouponInstanceStat(couponNos_);
				return recv_queryCouponInstanceStat(); 
				
			}
			
			
			private void send_queryCouponInstanceStat(List<string> couponNos_){
				
				InitInvocation("queryCouponInstanceStat");
				
				queryCouponInstanceStat_args args = new queryCouponInstanceStat_args();
				args.SetCouponNos(couponNos_);
				
				SendBase(args, queryCouponInstanceStat_argsHelper.getInstance());
			}
			
			
			private List<com.vip.pms.data.service.CouponInstanceStatResponse> recv_queryCouponInstanceStat(){
				
				queryCouponInstanceStat_result result = new queryCouponInstanceStat_result();
				ReceiveBase(result, queryCouponInstanceStat_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.pms.data.service.OrderFavDetailResult> queryGoodsFavAmount(List<com.vip.pms.data.service.OrderCouponRequest> orderCouponRequests_) {
				
				send_queryGoodsFavAmount(orderCouponRequests_);
				return recv_queryGoodsFavAmount(); 
				
			}
			
			
			private void send_queryGoodsFavAmount(List<com.vip.pms.data.service.OrderCouponRequest> orderCouponRequests_){
				
				InitInvocation("queryGoodsFavAmount");
				
				queryGoodsFavAmount_args args = new queryGoodsFavAmount_args();
				args.SetOrderCouponRequests(orderCouponRequests_);
				
				SendBase(args, queryGoodsFavAmount_argsHelper.getInstance());
			}
			
			
			private List<com.vip.pms.data.service.OrderFavDetailResult> recv_queryGoodsFavAmount(){
				
				queryGoodsFavAmount_result result = new queryGoodsFavAmount_result();
				ReceiveBase(result, queryGoodsFavAmount_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public bool? refreshOrder(string orderNo_,string hashValue_,byte refIdType_,long? userId_) {
				
				send_refreshOrder(orderNo_,hashValue_,refIdType_,userId_);
				return recv_refreshOrder(); 
				
			}
			
			
			private void send_refreshOrder(string orderNo_,string hashValue_,byte refIdType_,long? userId_){
				
				InitInvocation("refreshOrder");
				
				refreshOrder_args args = new refreshOrder_args();
				args.SetOrderNo(orderNo_);
				args.SetHashValue(hashValue_);
				args.SetRefIdType(refIdType_);
				args.SetUserId(userId_);
				
				SendBase(args, refreshOrder_argsHelper.getInstance());
			}
			
			
			private bool? recv_refreshOrder(){
				
				refreshOrder_result result = new refreshOrder_result();
				ReceiveBase(result, refreshOrder_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public bool? returnCoupon(string userId_,List<string> couponSns_) {
				
				send_returnCoupon(userId_,couponSns_);
				return recv_returnCoupon(); 
				
			}
			
			
			private void send_returnCoupon(string userId_,List<string> couponSns_){
				
				InitInvocation("returnCoupon");
				
				returnCoupon_args args = new returnCoupon_args();
				args.SetUserId(userId_);
				args.SetCouponSns(couponSns_);
				
				SendBase(args, returnCoupon_argsHelper.getInstance());
			}
			
			
			private bool? recv_returnCoupon(){
				
				returnCoupon_result result = new returnCoupon_result();
				ReceiveBase(result, returnCoupon_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public void saveActPromotionObject(com.vip.pms.data.model.sync.ActObjectRequest request_) {
				
				send_saveActPromotionObject(request_);
				recv_saveActPromotionObject();
				
			}
			
			
			private void send_saveActPromotionObject(com.vip.pms.data.model.sync.ActObjectRequest request_){
				
				InitInvocation("saveActPromotionObject");
				
				saveActPromotionObject_args args = new saveActPromotionObject_args();
				args.SetRequest(request_);
				
				SendBase(args, saveActPromotionObject_argsHelper.getInstance());
			}
			
			
			private void recv_saveActPromotionObject(){
				
				saveActPromotionObject_result result = new saveActPromotionObject_result();
				ReceiveBase(result, saveActPromotionObject_resultHelper.getInstance());
				
				
			}
			
			
			public void saveActivity(com.vip.pms.data.service.ActivityRequestModel request_) {
				
				send_saveActivity(request_);
				recv_saveActivity();
				
			}
			
			
			private void send_saveActivity(com.vip.pms.data.service.ActivityRequestModel request_){
				
				InitInvocation("saveActivity");
				
				saveActivity_args args = new saveActivity_args();
				args.SetRequest(request_);
				
				SendBase(args, saveActivity_argsHelper.getInstance());
			}
			
			
			private void recv_saveActivity(){
				
				saveActivity_result result = new saveActivity_result();
				ReceiveBase(result, saveActivity_resultHelper.getInstance());
				
				
			}
			
			
			public void saveSpecial(com.vip.pms.data.service.SpecialRequestModel request_) {
				
				send_saveSpecial(request_);
				recv_saveSpecial();
				
			}
			
			
			private void send_saveSpecial(com.vip.pms.data.service.SpecialRequestModel request_){
				
				InitInvocation("saveSpecial");
				
				saveSpecial_args args = new saveSpecial_args();
				args.SetRequest(request_);
				
				SendBase(args, saveSpecial_argsHelper.getInstance());
			}
			
			
			private void recv_saveSpecial(){
				
				saveSpecial_result result = new saveSpecial_result();
				ReceiveBase(result, saveSpecial_resultHelper.getInstance());
				
				
			}
			
			
			public void saveSpecialPromotionObject(com.vip.pms.data.model.sync.SpecialObjectRequest request_) {
				
				send_saveSpecialPromotionObject(request_);
				recv_saveSpecialPromotionObject();
				
			}
			
			
			private void send_saveSpecialPromotionObject(com.vip.pms.data.model.sync.SpecialObjectRequest request_){
				
				InitInvocation("saveSpecialPromotionObject");
				
				saveSpecialPromotionObject_args args = new saveSpecialPromotionObject_args();
				args.SetRequest(request_);
				
				SendBase(args, saveSpecialPromotionObject_argsHelper.getInstance());
			}
			
			
			private void recv_saveSpecialPromotionObject(){
				
				saveSpecialPromotionObject_result result = new saveSpecialPromotionObject_result();
				ReceiveBase(result, saveSpecialPromotionObject_resultHelper.getInstance());
				
				
			}
			
			
			public void submitSMSendingRequest(com.vip.pms.data.service.SMSRequestModel smsRequestModel_) {
				
				send_submitSMSendingRequest(smsRequestModel_);
				recv_submitSMSendingRequest();
				
			}
			
			
			private void send_submitSMSendingRequest(com.vip.pms.data.service.SMSRequestModel smsRequestModel_){
				
				InitInvocation("submitSMSendingRequest");
				
				submitSMSendingRequest_args args = new submitSMSendingRequest_args();
				args.SetSmsRequestModel(smsRequestModel_);
				
				SendBase(args, submitSMSendingRequest_argsHelper.getInstance());
			}
			
			
			private void recv_submitSMSendingRequest(){
				
				submitSMSendingRequest_result result = new submitSMSendingRequest_result();
				ReceiveBase(result, submitSMSendingRequest_resultHelper.getInstance());
				
				
			}
			
			
			public bool? syncAllActivityIndex(string indexType_) {
				
				send_syncAllActivityIndex(indexType_);
				return recv_syncAllActivityIndex(); 
				
			}
			
			
			private void send_syncAllActivityIndex(string indexType_){
				
				InitInvocation("syncAllActivityIndex");
				
				syncAllActivityIndex_args args = new syncAllActivityIndex_args();
				args.SetIndexType(indexType_);
				
				SendBase(args, syncAllActivityIndex_argsHelper.getInstance());
			}
			
			
			private bool? recv_syncAllActivityIndex(){
				
				syncAllActivityIndex_result result = new syncAllActivityIndex_result();
				ReceiveBase(result, syncAllActivityIndex_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public bool? syncAllCacheByCacheType(int? cacheType_,int? scope_) {
				
				send_syncAllCacheByCacheType(cacheType_,scope_);
				return recv_syncAllCacheByCacheType(); 
				
			}
			
			
			private void send_syncAllCacheByCacheType(int? cacheType_,int? scope_){
				
				InitInvocation("syncAllCacheByCacheType");
				
				syncAllCacheByCacheType_args args = new syncAllCacheByCacheType_args();
				args.SetCacheType(cacheType_);
				args.SetScope(scope_);
				
				SendBase(args, syncAllCacheByCacheType_argsHelper.getInstance());
			}
			
			
			private bool? recv_syncAllCacheByCacheType(){
				
				syncAllCacheByCacheType_result result = new syncAllCacheByCacheType_result();
				ReceiveBase(result, syncAllCacheByCacheType_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public void syncAllGoodsOriginalPrice() {
				
				send_syncAllGoodsOriginalPrice();
				recv_syncAllGoodsOriginalPrice();
				
			}
			
			
			private void send_syncAllGoodsOriginalPrice(){
				
				InitInvocation("syncAllGoodsOriginalPrice");
				
				syncAllGoodsOriginalPrice_args args = new syncAllGoodsOriginalPrice_args();
				
				SendBase(args, syncAllGoodsOriginalPrice_argsHelper.getInstance());
			}
			
			
			private void recv_syncAllGoodsOriginalPrice(){
				
				syncAllGoodsOriginalPrice_result result = new syncAllGoodsOriginalPrice_result();
				ReceiveBase(result, syncAllGoodsOriginalPrice_resultHelper.getInstance());
				
				
			}
			
			
			public void syncAllGoodsSurprisePrice() {
				
				send_syncAllGoodsSurprisePrice();
				recv_syncAllGoodsSurprisePrice();
				
			}
			
			
			private void send_syncAllGoodsSurprisePrice(){
				
				InitInvocation("syncAllGoodsSurprisePrice");
				
				syncAllGoodsSurprisePrice_args args = new syncAllGoodsSurprisePrice_args();
				
				SendBase(args, syncAllGoodsSurprisePrice_argsHelper.getInstance());
			}
			
			
			private void recv_syncAllGoodsSurprisePrice(){
				
				syncAllGoodsSurprisePrice_result result = new syncAllGoodsSurprisePrice_result();
				ReceiveBase(result, syncAllGoodsSurprisePrice_resultHelper.getInstance());
				
				
			}
			
			
			public bool? syncBiPush(com.vip.pms.data.service.BiPushTypeEnum? biPushType_) {
				
				send_syncBiPush(biPushType_);
				return recv_syncBiPush(); 
				
			}
			
			
			private void send_syncBiPush(com.vip.pms.data.service.BiPushTypeEnum? biPushType_){
				
				InitInvocation("syncBiPush");
				
				syncBiPush_args args = new syncBiPush_args();
				args.SetBiPushType(biPushType_);
				
				SendBase(args, syncBiPush_argsHelper.getInstance());
			}
			
			
			private bool? recv_syncBiPush(){
				
				syncBiPush_result result = new syncBiPush_result();
				ReceiveBase(result, syncBiPush_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public bool? syncBlacklistNew(List<com.vip.pms.data.service.BlacklistModel> blacklist_) {
				
				send_syncBlacklistNew(blacklist_);
				return recv_syncBlacklistNew(); 
				
			}
			
			
			private void send_syncBlacklistNew(List<com.vip.pms.data.service.BlacklistModel> blacklist_){
				
				InitInvocation("syncBlacklistNew");
				
				syncBlacklistNew_args args = new syncBlacklistNew_args();
				args.SetBlacklist(blacklist_);
				
				SendBase(args, syncBlacklistNew_argsHelper.getInstance());
			}
			
			
			private bool? recv_syncBlacklistNew(){
				
				syncBlacklistNew_result result = new syncBlacklistNew_result();
				ReceiveBase(result, syncBlacklistNew_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public bool? syncCacheByActivityNosAndCacheType(List<string> activityNos_,int? cacheType_,List<int?> scopes_) {
				
				send_syncCacheByActivityNosAndCacheType(activityNos_,cacheType_,scopes_);
				return recv_syncCacheByActivityNosAndCacheType(); 
				
			}
			
			
			private void send_syncCacheByActivityNosAndCacheType(List<string> activityNos_,int? cacheType_,List<int?> scopes_){
				
				InitInvocation("syncCacheByActivityNosAndCacheType");
				
				syncCacheByActivityNosAndCacheType_args args = new syncCacheByActivityNosAndCacheType_args();
				args.SetActivityNos(activityNos_);
				args.SetCacheType(cacheType_);
				args.SetScopes(scopes_);
				
				SendBase(args, syncCacheByActivityNosAndCacheType_argsHelper.getInstance());
			}
			
			
			private bool? recv_syncCacheByActivityNosAndCacheType(){
				
				syncCacheByActivityNosAndCacheType_result result = new syncCacheByActivityNosAndCacheType_result();
				ReceiveBase(result, syncCacheByActivityNosAndCacheType_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public bool? syncPayBlackList(List<string> blackIds_) {
				
				send_syncPayBlackList(blackIds_);
				return recv_syncPayBlackList(); 
				
			}
			
			
			private void send_syncPayBlackList(List<string> blackIds_){
				
				InitInvocation("syncPayBlackList");
				
				syncPayBlackList_args args = new syncPayBlackList_args();
				args.SetBlackIds(blackIds_);
				
				SendBase(args, syncPayBlackList_argsHelper.getInstance());
			}
			
			
			private bool? recv_syncPayBlackList(){
				
				syncPayBlackList_result result = new syncPayBlackList_result();
				ReceiveBase(result, syncPayBlackList_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public void updateActPromotionObject(com.vip.pms.data.model.sync.ActObjectUpdateRequest request_) {
				
				send_updateActPromotionObject(request_);
				recv_updateActPromotionObject();
				
			}
			
			
			private void send_updateActPromotionObject(com.vip.pms.data.model.sync.ActObjectUpdateRequest request_){
				
				InitInvocation("updateActPromotionObject");
				
				updateActPromotionObject_args args = new updateActPromotionObject_args();
				args.SetRequest(request_);
				
				SendBase(args, updateActPromotionObject_argsHelper.getInstance());
			}
			
			
			private void recv_updateActPromotionObject(){
				
				updateActPromotionObject_result result = new updateActPromotionObject_result();
				ReceiveBase(result, updateActPromotionObject_resultHelper.getInstance());
				
				
			}
			
			
			public void updateActivityBaseInfo(com.vip.pms.data.service.ActivityRequestModel request_) {
				
				send_updateActivityBaseInfo(request_);
				recv_updateActivityBaseInfo();
				
			}
			
			
			private void send_updateActivityBaseInfo(com.vip.pms.data.service.ActivityRequestModel request_){
				
				InitInvocation("updateActivityBaseInfo");
				
				updateActivityBaseInfo_args args = new updateActivityBaseInfo_args();
				args.SetRequest(request_);
				
				SendBase(args, updateActivityBaseInfo_argsHelper.getInstance());
			}
			
			
			private void recv_updateActivityBaseInfo(){
				
				updateActivityBaseInfo_result result = new updateActivityBaseInfo_result();
				ReceiveBase(result, updateActivityBaseInfo_resultHelper.getInstance());
				
				
			}
			
			
			public void updateSpecialBaseInfo(com.vip.pms.data.service.SpecialRequestModel request_) {
				
				send_updateSpecialBaseInfo(request_);
				recv_updateSpecialBaseInfo();
				
			}
			
			
			private void send_updateSpecialBaseInfo(com.vip.pms.data.service.SpecialRequestModel request_){
				
				InitInvocation("updateSpecialBaseInfo");
				
				updateSpecialBaseInfo_args args = new updateSpecialBaseInfo_args();
				args.SetRequest(request_);
				
				SendBase(args, updateSpecialBaseInfo_argsHelper.getInstance());
			}
			
			
			private void recv_updateSpecialBaseInfo(){
				
				updateSpecialBaseInfo_result result = new updateSpecialBaseInfo_result();
				ReceiveBase(result, updateSpecialBaseInfo_resultHelper.getInstance());
				
				
			}
			
			
			public void updateSpecialPromotionObject(com.vip.pms.data.model.sync.ActObjectUpdateRequest request_) {
				
				send_updateSpecialPromotionObject(request_);
				recv_updateSpecialPromotionObject();
				
			}
			
			
			private void send_updateSpecialPromotionObject(com.vip.pms.data.model.sync.ActObjectUpdateRequest request_){
				
				InitInvocation("updateSpecialPromotionObject");
				
				updateSpecialPromotionObject_args args = new updateSpecialPromotionObject_args();
				args.SetRequest(request_);
				
				SendBase(args, updateSpecialPromotionObject_argsHelper.getInstance());
			}
			
			
			private void recv_updateSpecialPromotionObject(){
				
				updateSpecialPromotionObject_result result = new updateSpecialPromotionObject_result();
				ReceiveBase(result, updateSpecialPromotionObject_resultHelper.getInstance());
				
				
			}
			
			
		}
		
		
	}
	
}