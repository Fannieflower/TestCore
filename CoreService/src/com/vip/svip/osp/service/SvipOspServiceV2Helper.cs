using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.svip.osp.service{
	
	
	public class SvipOspServiceV2Helper {
		
		
		
		public class SearchSvipHistory_args {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.SearchSvipHistoryRequest request_;
			
			public com.vip.svip.osp.service.SearchSvipHistoryRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.svip.osp.service.SearchSvipHistoryRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class batchCancel_args {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.BatchCancelRequest request_;
			
			public com.vip.svip.osp.service.BatchCancelRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.svip.osp.service.BatchCancelRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class batchCancelV2_args {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.BatchCancelRequestV2 request_;
			
			public com.vip.svip.osp.service.BatchCancelRequestV2 GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.svip.osp.service.BatchCancelRequestV2 value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class bindTxUserAccount_args {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.BindTxAccRequest request_;
			
			public com.vip.svip.osp.service.BindTxAccRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.svip.osp.service.BindTxAccRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class brandGiftDetailList_args {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.BrandGiftDetailRequest request_;
			
			public com.vip.svip.osp.service.BrandGiftDetailRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.svip.osp.service.BrandGiftDetailRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class checkTxAccLimit_args {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.CheckTxAccLimitRequest request_;
			
			public com.vip.svip.osp.service.CheckTxAccLimitRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.svip.osp.service.CheckTxAccLimitRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class doCancelJob_args {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.DoCancelJobRequest request_;
			
			public com.vip.svip.osp.service.DoCancelJobRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.svip.osp.service.DoCancelJobRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class doCancelSvipUser_args {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.DoCancelRequest request_;
			
			public com.vip.svip.osp.service.DoCancelRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.svip.osp.service.DoCancelRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class draw_args {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.DrawRequest request_;
			
			public com.vip.svip.osp.service.DrawRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.svip.osp.service.DrawRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class getBindAccountInfo_args {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.GetBindAccountRequest request_;
			
			public com.vip.svip.osp.service.GetBindAccountRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.svip.osp.service.GetBindAccountRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class getBrandGiftIdList_args {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.BrandGiftRequest request_;
			
			public com.vip.svip.osp.service.BrandGiftRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.svip.osp.service.BrandGiftRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class getBuyLimitResult_args {
			
			///<summary>
			/// 请求头
			///</summary>
			
			private com.vip.svip.osp.service.BuyLimitRequestHeader header_;
			
			///<summary>
			/// 请求参数
			///</summary>
			
			private com.vip.svip.osp.service.BuyLimitRequestParam param_;
			
			public com.vip.svip.osp.service.BuyLimitRequestHeader GetHeader(){
				return this.header_;
			}
			
			public void SetHeader(com.vip.svip.osp.service.BuyLimitRequestHeader value){
				this.header_ = value;
			}
			public com.vip.svip.osp.service.BuyLimitRequestParam GetParam(){
				return this.param_;
			}
			
			public void SetParam(com.vip.svip.osp.service.BuyLimitRequestParam value){
				this.param_ = value;
			}
			
		}
		
		
		
		
		public class getGoodsIdByPickNo_args {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.GetGoodsIdByPickNoReq request_;
			
			public com.vip.svip.osp.service.GetGoodsIdByPickNoReq GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.svip.osp.service.GetGoodsIdByPickNoReq value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class getGroupValuesConf_args {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.GetGroupValuesRequest request_;
			
			public com.vip.svip.osp.service.GetGroupValuesRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.svip.osp.service.GetGroupValuesRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class getOpGoodsDetailList_args {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.GetOpGoodsDetailRequest request_;
			
			public com.vip.svip.osp.service.GetOpGoodsDetailRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.svip.osp.service.GetOpGoodsDetailRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class getOpGoodsIds_args {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.GetOpGoodsIdRequest request_;
			
			public com.vip.svip.osp.service.GetOpGoodsIdRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.svip.osp.service.GetOpGoodsIdRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class getPmsPriceByProductId_args {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.BrandGoodsPriceRequest request_;
			
			public com.vip.svip.osp.service.BrandGoodsPriceRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.svip.osp.service.BrandGoodsPriceRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class getSumCount_args {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.GetSumCountRequest request_;
			
			public com.vip.svip.osp.service.GetSumCountRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.svip.osp.service.GetSumCountRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class getSvipBindInfo_args {
			
			
		}
		
		
		
		
		public class getSvipBindInfoByUserId_args {
			
			///<summary>
			///</summary>
			
			private long? userId_;
			
			public long? GetUserId(){
				return this.userId_;
			}
			
			public void SetUserId(long? value){
				this.userId_ = value;
			}
			
		}
		
		
		
		
		public class getSvipGoodsByMid_args {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.GetSvipGoodsRequest request_;
			
			public com.vip.svip.osp.service.GetSvipGoodsRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.svip.osp.service.GetSvipGoodsRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class getSvipGoodsDetail_args {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.GetSvipGoodsDetailReq request_;
			
			public com.vip.svip.osp.service.GetSvipGoodsDetailReq GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.svip.osp.service.GetSvipGoodsDetailReq value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class getSvipInfo4AppClub_args {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.GetSvipInfo4AppClubRequest request_;
			
			public com.vip.svip.osp.service.GetSvipInfo4AppClubRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.svip.osp.service.GetSvipInfo4AppClubRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class getSvipMainInfo_args {
			
			///<summary>
			/// 请求头
			///</summary>
			
			private com.vip.svip.osp.service.BaseRequestHeader header_;
			
			public com.vip.svip.osp.service.BaseRequestHeader GetHeader(){
				return this.header_;
			}
			
			public void SetHeader(com.vip.svip.osp.service.BaseRequestHeader value){
				this.header_ = value;
			}
			
		}
		
		
		
		
		public class getSvipUserHealth_args {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.GetSvipUserHealthReq req_;
			
			public com.vip.svip.osp.service.GetSvipUserHealthReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(com.vip.svip.osp.service.GetSvipUserHealthReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class getSvipUserInfo_args {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.SvipUserLimitStateReq req_;
			
			public com.vip.svip.osp.service.SvipUserLimitStateReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(com.vip.svip.osp.service.SvipUserLimitStateReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class getTencentVipSvipCardInfo_args {
			
			///<summary>
			///</summary>
			
			private long? userId_;
			
			public long? GetUserId(){
				return this.userId_;
			}
			
			public void SetUserId(long? value){
				this.userId_ = value;
			}
			
		}
		
		
		
		
		public class getTheTimeSvipPrice_args {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.GetTheTimeSvipPrice request_;
			
			public com.vip.svip.osp.service.GetTheTimeSvipPrice GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.svip.osp.service.GetTheTimeSvipPrice value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class getUserAttendInfo_args {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.UserAttendInfoRequest request_;
			
			public com.vip.svip.osp.service.UserAttendInfoRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.svip.osp.service.UserAttendInfoRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class isSvipBanArea_args {
			
			///<summary>
			///</summary>
			
			private string areaId_;
			
			public string GetAreaId(){
				return this.areaId_;
			}
			
			public void SetAreaId(string value){
				this.areaId_ = value;
			}
			
		}
		
		
		
		
		public class isSvipBuyLimit_args {
			
			///<summary>
			/// 请求头
			///</summary>
			
			private com.vip.svip.osp.service.BuyLimitRequestHeader header_;
			
			///<summary>
			/// 请求参数
			///</summary>
			
			private com.vip.svip.osp.service.BuyLimitRequestParam param_;
			
			public com.vip.svip.osp.service.BuyLimitRequestHeader GetHeader(){
				return this.header_;
			}
			
			public void SetHeader(com.vip.svip.osp.service.BuyLimitRequestHeader value){
				this.header_ = value;
			}
			public com.vip.svip.osp.service.BuyLimitRequestParam GetParam(){
				return this.param_;
			}
			
			public void SetParam(com.vip.svip.osp.service.BuyLimitRequestParam value){
				this.param_ = value;
			}
			
		}
		
		
		
		
		public class isSvipLimitUser_args {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.BuyLimitStateRequest request_;
			
			public com.vip.svip.osp.service.BuyLimitStateRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.svip.osp.service.BuyLimitStateRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class isSvipLimitUserByPhone_args {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.CheckSvipUserLimitByPhoneParam request_;
			
			public com.vip.svip.osp.service.CheckSvipUserLimitByPhoneParam GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.svip.osp.service.CheckSvipUserLimitByPhoneParam value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class joinSvipForTencentVideoSide_args {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.DoubleSvipRequest request_;
			
			public com.vip.svip.osp.service.DoubleSvipRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.svip.osp.service.DoubleSvipRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class joinTencentVideoMemberAtVipSide_args {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.DoubleSvipRequest request_;
			
			public com.vip.svip.osp.service.DoubleSvipRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.svip.osp.service.DoubleSvipRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class offlineChannelTrySvip_args {
			
			///<summary>
			/// 请求头
			///</summary>
			
			private com.vip.svip.osp.service.SimpleRequestHeader header_;
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.OfflineChannelInfo channelInfo_;
			
			public com.vip.svip.osp.service.SimpleRequestHeader GetHeader(){
				return this.header_;
			}
			
			public void SetHeader(com.vip.svip.osp.service.SimpleRequestHeader value){
				this.header_ = value;
			}
			public com.vip.svip.osp.service.OfflineChannelInfo GetChannelInfo(){
				return this.channelInfo_;
			}
			
			public void SetChannelInfo(com.vip.svip.osp.service.OfflineChannelInfo value){
				this.channelInfo_ = value;
			}
			
		}
		
		
		
		
		public class openLimitCheck_args {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.OpenLimitRequest request_;
			
			public com.vip.svip.osp.service.OpenLimitRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.svip.osp.service.OpenLimitRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class prepareDoubleSvipAccess_args {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.DoubleSvipRequest request_;
			
			public com.vip.svip.osp.service.DoubleSvipRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.svip.osp.service.DoubleSvipRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class receivePrize_args {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.ReceivePrizeRequest request_;
			
			public com.vip.svip.osp.service.ReceivePrizeRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.svip.osp.service.ReceivePrizeRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class rejoinTencentMember_args {
			
			///<summary>
			/// 补发流水号
			///</summary>
			
			private string serial_;
			
			///<summary>
			/// 补发操作人员
			///</summary>
			
			private string admin_;
			
			public string GetSerial(){
				return this.serial_;
			}
			
			public void SetSerial(string value){
				this.serial_ = value;
			}
			public string GetAdmin(){
				return this.admin_;
			}
			
			public void SetAdmin(string value){
				this.admin_ = value;
			}
			
		}
		
		
		
		
		public class retryOthersOperateRecord_args {
			
			
		}
		
		
		
		
		public class retryProcessGifts_args {
			
			
		}
		
		
		
		
		public class retrySvipExceptionLog_args {
			
			
		}
		
		
		
		
		public class retrySvipOperate_args {
			
			
		}
		
		
		
		
		public class scrapeAction_args {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.ScrapeActionRequest request_;
			
			public com.vip.svip.osp.service.ScrapeActionRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.svip.osp.service.ScrapeActionRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class searchSvipTXHistory_args {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.SearchSvipHistoryRequest request_;
			
			public com.vip.svip.osp.service.SearchSvipHistoryRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.svip.osp.service.SearchSvipHistoryRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class specialMemberTrySvip_args {
			
			///<summary>
			/// 请求头
			///</summary>
			
			private com.vip.svip.osp.service.SimpleRequestHeader header_;
			
			public com.vip.svip.osp.service.SimpleRequestHeader GetHeader(){
				return this.header_;
			}
			
			public void SetHeader(com.vip.svip.osp.service.SimpleRequestHeader value){
				this.header_ = value;
			}
			
		}
		
		
		
		
		public class svipUserOperate_args {
			
			///<summary>
			/// 操作信息
			///</summary>
			
			private com.vip.svip.osp.service.SvipUserOperateInfoParam info_;
			
			///<summary>
			/// SIGN校验参数
			///</summary>
			
			private com.vip.svip.osp.service.SvipUserOperateSignCheck signCheck_;
			
			public com.vip.svip.osp.service.SvipUserOperateInfoParam GetInfo(){
				return this.info_;
			}
			
			public void SetInfo(com.vip.svip.osp.service.SvipUserOperateInfoParam value){
				this.info_ = value;
			}
			public com.vip.svip.osp.service.SvipUserOperateSignCheck GetSignCheck(){
				return this.signCheck_;
			}
			
			public void SetSignCheck(com.vip.svip.osp.service.SvipUserOperateSignCheck value){
				this.signCheck_ = value;
			}
			
		}
		
		
		
		
		public class syncCancelResult_args {
			
			
		}
		
		
		
		
		public class txGetSvipToken_args {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.TxGetTokenRequest request_;
			
			public com.vip.svip.osp.service.TxGetTokenRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.svip.osp.service.TxGetTokenRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class txOpenSvip_args {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.TxOpenSvipRequest request_;
			
			public com.vip.svip.osp.service.TxOpenSvipRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.svip.osp.service.TxOpenSvipRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class vOrderCallSvip_args {
			
			///<summary>
			///</summary>
			
			private string json_;
			
			public string GetJson(){
				return this.json_;
			}
			
			public void SetJson(string value){
				this.json_ = value;
			}
			
		}
		
		
		
		
		public class SearchSvipHistory_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.svip.osp.service.SearchSvipHistoryResult> success_;
			
			public List<com.vip.svip.osp.service.SearchSvipHistoryResult> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.svip.osp.service.SearchSvipHistoryResult> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class batchCancel_result {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.BatchCancelBaseResult success_;
			
			public com.vip.svip.osp.service.BatchCancelBaseResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.svip.osp.service.BatchCancelBaseResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class batchCancelV2_result {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.BatchCancelBaseResult success_;
			
			public com.vip.svip.osp.service.BatchCancelBaseResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.svip.osp.service.BatchCancelBaseResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class bindTxUserAccount_result {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.BaseResult success_;
			
			public com.vip.svip.osp.service.BaseResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.svip.osp.service.BaseResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class brandGiftDetailList_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.svip.osp.service.BrandGiftItem> success_;
			
			public List<com.vip.svip.osp.service.BrandGiftItem> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.svip.osp.service.BrandGiftItem> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class checkTxAccLimit_result {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.BaseResult success_;
			
			public com.vip.svip.osp.service.BaseResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.svip.osp.service.BaseResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class doCancelJob_result {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.BaseResult success_;
			
			public com.vip.svip.osp.service.BaseResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.svip.osp.service.BaseResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class doCancelSvipUser_result {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.BaseResult success_;
			
			public com.vip.svip.osp.service.BaseResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.svip.osp.service.BaseResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class draw_result {
			
			///<summary>
			///</summary>
			
			private string success_;
			
			public string GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(string value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getBindAccountInfo_result {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.AccountInfoResult success_;
			
			public com.vip.svip.osp.service.AccountInfoResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.svip.osp.service.AccountInfoResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getBrandGiftIdList_result {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.BrandGiftIdResult success_;
			
			public com.vip.svip.osp.service.BrandGiftIdResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.svip.osp.service.BrandGiftIdResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getBuyLimitResult_result {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.BuyLimitResult success_;
			
			public com.vip.svip.osp.service.BuyLimitResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.svip.osp.service.BuyLimitResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getGoodsIdByPickNo_result {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.GetGoodsIdByPickNoResult success_;
			
			public com.vip.svip.osp.service.GetGoodsIdByPickNoResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.svip.osp.service.GetGoodsIdByPickNoResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getGroupValuesConf_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.svip.osp.service.GroupValues> success_;
			
			public List<com.vip.svip.osp.service.GroupValues> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.svip.osp.service.GroupValues> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getOpGoodsDetailList_result {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.GetOpGoodsDetailResult success_;
			
			public com.vip.svip.osp.service.GetOpGoodsDetailResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.svip.osp.service.GetOpGoodsDetailResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getOpGoodsIds_result {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.GetOpGoodsIdResult success_;
			
			public com.vip.svip.osp.service.GetOpGoodsIdResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.svip.osp.service.GetOpGoodsIdResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getPmsPriceByProductId_result {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.BrandGoodsPriceResult success_;
			
			public com.vip.svip.osp.service.BrandGoodsPriceResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.svip.osp.service.BrandGoodsPriceResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getSumCount_result {
			
			///<summary>
			///</summary>
			
			private string success_;
			
			public string GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(string value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getSvipBindInfo_result {
			
			///<summary>
			///</summary>
			
			private string success_;
			
			public string GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(string value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getSvipBindInfoByUserId_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.svip.osp.service.SvipBindInfo> success_;
			
			public List<com.vip.svip.osp.service.SvipBindInfo> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.svip.osp.service.SvipBindInfo> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getSvipGoodsByMid_result {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.GetSvipGoodsResult success_;
			
			public com.vip.svip.osp.service.GetSvipGoodsResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.svip.osp.service.GetSvipGoodsResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getSvipGoodsDetail_result {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.GetSvipGoodsDetailResult success_;
			
			public com.vip.svip.osp.service.GetSvipGoodsDetailResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.svip.osp.service.GetSvipGoodsDetailResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getSvipInfo4AppClub_result {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.GetSvipInfo4AppClubResult success_;
			
			public com.vip.svip.osp.service.GetSvipInfo4AppClubResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.svip.osp.service.GetSvipInfo4AppClubResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getSvipMainInfo_result {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.KTBaseInfoResult success_;
			
			public com.vip.svip.osp.service.KTBaseInfoResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.svip.osp.service.KTBaseInfoResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getSvipUserHealth_result {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.SvipUserHealthResp success_;
			
			public com.vip.svip.osp.service.SvipUserHealthResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.svip.osp.service.SvipUserHealthResp value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getSvipUserInfo_result {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.SvipUserLimitStateResp success_;
			
			public com.vip.svip.osp.service.SvipUserLimitStateResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.svip.osp.service.SvipUserLimitStateResp value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getTencentVipSvipCardInfo_result {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.TencentSvipGoodsInfo success_;
			
			public com.vip.svip.osp.service.TencentSvipGoodsInfo GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.svip.osp.service.TencentSvipGoodsInfo value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getTheTimeSvipPrice_result {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.GetTheTimeSvipPriceResult success_;
			
			public com.vip.svip.osp.service.GetTheTimeSvipPriceResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.svip.osp.service.GetTheTimeSvipPriceResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getUserAttendInfo_result {
			
			///<summary>
			///</summary>
			
			private string success_;
			
			public string GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(string value){
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
		
		
		
		
		public class isSvipBanArea_result {
			
			///<summary>
			///</summary>
			
			private string success_;
			
			public string GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(string value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class isSvipBuyLimit_result {
			
			///<summary>
			/// 
			///</summary>
			
			private com.vip.svip.osp.service.BuyLimitResult success_;
			
			public com.vip.svip.osp.service.BuyLimitResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.svip.osp.service.BuyLimitResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class isSvipLimitUser_result {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.BuyLimitState success_;
			
			public com.vip.svip.osp.service.BuyLimitState GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.svip.osp.service.BuyLimitState value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class isSvipLimitUserByPhone_result {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.BuyLimitState success_;
			
			public com.vip.svip.osp.service.BuyLimitState GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.svip.osp.service.BuyLimitState value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class joinSvipForTencentVideoSide_result {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.DoubleSvipCreateResponse success_;
			
			public com.vip.svip.osp.service.DoubleSvipCreateResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.svip.osp.service.DoubleSvipCreateResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class joinTencentVideoMemberAtVipSide_result {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.BaseResult success_;
			
			public com.vip.svip.osp.service.BaseResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.svip.osp.service.BaseResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class offlineChannelTrySvip_result {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.BaseResult success_;
			
			public com.vip.svip.osp.service.BaseResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.svip.osp.service.BaseResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class openLimitCheck_result {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.BuyLimitResult success_;
			
			public com.vip.svip.osp.service.BuyLimitResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.svip.osp.service.BuyLimitResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class prepareDoubleSvipAccess_result {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.DoubleSvipStatus success_;
			
			public com.vip.svip.osp.service.DoubleSvipStatus GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.svip.osp.service.DoubleSvipStatus value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class receivePrize_result {
			
			///<summary>
			///</summary>
			
			private string success_;
			
			public string GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(string value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class rejoinTencentMember_result {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.BaseResult success_;
			
			public com.vip.svip.osp.service.BaseResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.svip.osp.service.BaseResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class retryOthersOperateRecord_result {
			
			
		}
		
		
		
		
		public class retryProcessGifts_result {
			
			
		}
		
		
		
		
		public class retrySvipExceptionLog_result {
			
			
		}
		
		
		
		
		public class retrySvipOperate_result {
			
			
		}
		
		
		
		
		public class scrapeAction_result {
			
			///<summary>
			///</summary>
			
			private string success_;
			
			public string GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(string value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class searchSvipTXHistory_result {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.SvipTXBindHistoryResult success_;
			
			public com.vip.svip.osp.service.SvipTXBindHistoryResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.svip.osp.service.SvipTXBindHistoryResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class specialMemberTrySvip_result {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.BaseResult success_;
			
			public com.vip.svip.osp.service.BaseResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.svip.osp.service.BaseResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class svipUserOperate_result {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.SvipOperateResult success_;
			
			public com.vip.svip.osp.service.SvipOperateResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.svip.osp.service.SvipOperateResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class syncCancelResult_result {
			
			
		}
		
		
		
		
		public class txGetSvipToken_result {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.TxGetSvipTokenResult success_;
			
			public com.vip.svip.osp.service.TxGetSvipTokenResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.svip.osp.service.TxGetSvipTokenResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class txOpenSvip_result {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.DoubleSvipCreateResponse success_;
			
			public com.vip.svip.osp.service.DoubleSvipCreateResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.svip.osp.service.DoubleSvipCreateResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class vOrderCallSvip_result {
			
			///<summary>
			///</summary>
			
			private com.vip.svip.osp.service.SvipOperateResult success_;
			
			public com.vip.svip.osp.service.SvipOperateResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.svip.osp.service.SvipOperateResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		
		public class SearchSvipHistory_argsHelper : TBeanSerializer<SearchSvipHistory_args>
		{
			
			public static SearchSvipHistory_argsHelper OBJ = new SearchSvipHistory_argsHelper();
			
			public static SearchSvipHistory_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(SearchSvipHistory_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.SearchSvipHistoryRequest value;
					
					value = new com.vip.svip.osp.service.SearchSvipHistoryRequest();
					com.vip.svip.osp.service.SearchSvipHistoryRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(SearchSvipHistory_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.svip.osp.service.SearchSvipHistoryRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(SearchSvipHistory_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchCancel_argsHelper : TBeanSerializer<batchCancel_args>
		{
			
			public static batchCancel_argsHelper OBJ = new batchCancel_argsHelper();
			
			public static batchCancel_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchCancel_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.BatchCancelRequest value;
					
					value = new com.vip.svip.osp.service.BatchCancelRequest();
					com.vip.svip.osp.service.BatchCancelRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(batchCancel_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.svip.osp.service.BatchCancelRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchCancel_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchCancelV2_argsHelper : TBeanSerializer<batchCancelV2_args>
		{
			
			public static batchCancelV2_argsHelper OBJ = new batchCancelV2_argsHelper();
			
			public static batchCancelV2_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchCancelV2_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.BatchCancelRequestV2 value;
					
					value = new com.vip.svip.osp.service.BatchCancelRequestV2();
					com.vip.svip.osp.service.BatchCancelRequestV2Helper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(batchCancelV2_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.svip.osp.service.BatchCancelRequestV2Helper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchCancelV2_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class bindTxUserAccount_argsHelper : TBeanSerializer<bindTxUserAccount_args>
		{
			
			public static bindTxUserAccount_argsHelper OBJ = new bindTxUserAccount_argsHelper();
			
			public static bindTxUserAccount_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(bindTxUserAccount_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.BindTxAccRequest value;
					
					value = new com.vip.svip.osp.service.BindTxAccRequest();
					com.vip.svip.osp.service.BindTxAccRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(bindTxUserAccount_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.svip.osp.service.BindTxAccRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(bindTxUserAccount_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class brandGiftDetailList_argsHelper : TBeanSerializer<brandGiftDetailList_args>
		{
			
			public static brandGiftDetailList_argsHelper OBJ = new brandGiftDetailList_argsHelper();
			
			public static brandGiftDetailList_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(brandGiftDetailList_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.BrandGiftDetailRequest value;
					
					value = new com.vip.svip.osp.service.BrandGiftDetailRequest();
					com.vip.svip.osp.service.BrandGiftDetailRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(brandGiftDetailList_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.svip.osp.service.BrandGiftDetailRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(brandGiftDetailList_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class checkTxAccLimit_argsHelper : TBeanSerializer<checkTxAccLimit_args>
		{
			
			public static checkTxAccLimit_argsHelper OBJ = new checkTxAccLimit_argsHelper();
			
			public static checkTxAccLimit_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(checkTxAccLimit_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.CheckTxAccLimitRequest value;
					
					value = new com.vip.svip.osp.service.CheckTxAccLimitRequest();
					com.vip.svip.osp.service.CheckTxAccLimitRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(checkTxAccLimit_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.svip.osp.service.CheckTxAccLimitRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(checkTxAccLimit_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class doCancelJob_argsHelper : TBeanSerializer<doCancelJob_args>
		{
			
			public static doCancelJob_argsHelper OBJ = new doCancelJob_argsHelper();
			
			public static doCancelJob_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(doCancelJob_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.DoCancelJobRequest value;
					
					value = new com.vip.svip.osp.service.DoCancelJobRequest();
					com.vip.svip.osp.service.DoCancelJobRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(doCancelJob_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.svip.osp.service.DoCancelJobRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(doCancelJob_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class doCancelSvipUser_argsHelper : TBeanSerializer<doCancelSvipUser_args>
		{
			
			public static doCancelSvipUser_argsHelper OBJ = new doCancelSvipUser_argsHelper();
			
			public static doCancelSvipUser_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(doCancelSvipUser_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.DoCancelRequest value;
					
					value = new com.vip.svip.osp.service.DoCancelRequest();
					com.vip.svip.osp.service.DoCancelRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(doCancelSvipUser_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.svip.osp.service.DoCancelRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(doCancelSvipUser_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class draw_argsHelper : TBeanSerializer<draw_args>
		{
			
			public static draw_argsHelper OBJ = new draw_argsHelper();
			
			public static draw_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(draw_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.DrawRequest value;
					
					value = new com.vip.svip.osp.service.DrawRequest();
					com.vip.svip.osp.service.DrawRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(draw_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.svip.osp.service.DrawRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(draw_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getBindAccountInfo_argsHelper : TBeanSerializer<getBindAccountInfo_args>
		{
			
			public static getBindAccountInfo_argsHelper OBJ = new getBindAccountInfo_argsHelper();
			
			public static getBindAccountInfo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getBindAccountInfo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.GetBindAccountRequest value;
					
					value = new com.vip.svip.osp.service.GetBindAccountRequest();
					com.vip.svip.osp.service.GetBindAccountRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getBindAccountInfo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.svip.osp.service.GetBindAccountRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getBindAccountInfo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getBrandGiftIdList_argsHelper : TBeanSerializer<getBrandGiftIdList_args>
		{
			
			public static getBrandGiftIdList_argsHelper OBJ = new getBrandGiftIdList_argsHelper();
			
			public static getBrandGiftIdList_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getBrandGiftIdList_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.BrandGiftRequest value;
					
					value = new com.vip.svip.osp.service.BrandGiftRequest();
					com.vip.svip.osp.service.BrandGiftRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getBrandGiftIdList_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.svip.osp.service.BrandGiftRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getBrandGiftIdList_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getBuyLimitResult_argsHelper : TBeanSerializer<getBuyLimitResult_args>
		{
			
			public static getBuyLimitResult_argsHelper OBJ = new getBuyLimitResult_argsHelper();
			
			public static getBuyLimitResult_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getBuyLimitResult_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.BuyLimitRequestHeader value;
					
					value = new com.vip.svip.osp.service.BuyLimitRequestHeader();
					com.vip.svip.osp.service.BuyLimitRequestHeaderHelper.getInstance().Read(value, iprot);
					
					structs.SetHeader(value);
				}
				
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.BuyLimitRequestParam value;
					
					value = new com.vip.svip.osp.service.BuyLimitRequestParam();
					com.vip.svip.osp.service.BuyLimitRequestParamHelper.getInstance().Read(value, iprot);
					
					structs.SetParam(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getBuyLimitResult_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetHeader() != null) {
					
					oprot.WriteFieldBegin("header");
					
					com.vip.svip.osp.service.BuyLimitRequestHeaderHelper.getInstance().Write(structs.GetHeader(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("header can not be null!");
				}
				
				
				if(structs.GetParam() != null) {
					
					oprot.WriteFieldBegin("param");
					
					com.vip.svip.osp.service.BuyLimitRequestParamHelper.getInstance().Write(structs.GetParam(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("param can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getBuyLimitResult_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getGoodsIdByPickNo_argsHelper : TBeanSerializer<getGoodsIdByPickNo_args>
		{
			
			public static getGoodsIdByPickNo_argsHelper OBJ = new getGoodsIdByPickNo_argsHelper();
			
			public static getGoodsIdByPickNo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getGoodsIdByPickNo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.GetGoodsIdByPickNoReq value;
					
					value = new com.vip.svip.osp.service.GetGoodsIdByPickNoReq();
					com.vip.svip.osp.service.GetGoodsIdByPickNoReqHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getGoodsIdByPickNo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.svip.osp.service.GetGoodsIdByPickNoReqHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getGoodsIdByPickNo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getGroupValuesConf_argsHelper : TBeanSerializer<getGroupValuesConf_args>
		{
			
			public static getGroupValuesConf_argsHelper OBJ = new getGroupValuesConf_argsHelper();
			
			public static getGroupValuesConf_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getGroupValuesConf_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.GetGroupValuesRequest value;
					
					value = new com.vip.svip.osp.service.GetGroupValuesRequest();
					com.vip.svip.osp.service.GetGroupValuesRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getGroupValuesConf_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.svip.osp.service.GetGroupValuesRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getGroupValuesConf_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getOpGoodsDetailList_argsHelper : TBeanSerializer<getOpGoodsDetailList_args>
		{
			
			public static getOpGoodsDetailList_argsHelper OBJ = new getOpGoodsDetailList_argsHelper();
			
			public static getOpGoodsDetailList_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOpGoodsDetailList_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.GetOpGoodsDetailRequest value;
					
					value = new com.vip.svip.osp.service.GetOpGoodsDetailRequest();
					com.vip.svip.osp.service.GetOpGoodsDetailRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getOpGoodsDetailList_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.svip.osp.service.GetOpGoodsDetailRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOpGoodsDetailList_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getOpGoodsIds_argsHelper : TBeanSerializer<getOpGoodsIds_args>
		{
			
			public static getOpGoodsIds_argsHelper OBJ = new getOpGoodsIds_argsHelper();
			
			public static getOpGoodsIds_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOpGoodsIds_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.GetOpGoodsIdRequest value;
					
					value = new com.vip.svip.osp.service.GetOpGoodsIdRequest();
					com.vip.svip.osp.service.GetOpGoodsIdRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getOpGoodsIds_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.svip.osp.service.GetOpGoodsIdRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOpGoodsIds_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPmsPriceByProductId_argsHelper : TBeanSerializer<getPmsPriceByProductId_args>
		{
			
			public static getPmsPriceByProductId_argsHelper OBJ = new getPmsPriceByProductId_argsHelper();
			
			public static getPmsPriceByProductId_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPmsPriceByProductId_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.BrandGoodsPriceRequest value;
					
					value = new com.vip.svip.osp.service.BrandGoodsPriceRequest();
					com.vip.svip.osp.service.BrandGoodsPriceRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getPmsPriceByProductId_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.svip.osp.service.BrandGoodsPriceRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPmsPriceByProductId_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSumCount_argsHelper : TBeanSerializer<getSumCount_args>
		{
			
			public static getSumCount_argsHelper OBJ = new getSumCount_argsHelper();
			
			public static getSumCount_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSumCount_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.GetSumCountRequest value;
					
					value = new com.vip.svip.osp.service.GetSumCountRequest();
					com.vip.svip.osp.service.GetSumCountRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSumCount_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.svip.osp.service.GetSumCountRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSumCount_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSvipBindInfo_argsHelper : TBeanSerializer<getSvipBindInfo_args>
		{
			
			public static getSvipBindInfo_argsHelper OBJ = new getSvipBindInfo_argsHelper();
			
			public static getSvipBindInfo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSvipBindInfo_args structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSvipBindInfo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSvipBindInfo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSvipBindInfoByUserId_argsHelper : TBeanSerializer<getSvipBindInfoByUserId_args>
		{
			
			public static getSvipBindInfoByUserId_argsHelper OBJ = new getSvipBindInfoByUserId_argsHelper();
			
			public static getSvipBindInfoByUserId_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSvipBindInfoByUserId_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetUserId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSvipBindInfoByUserId_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetUserId() != null) {
					
					oprot.WriteFieldBegin("userId");
					oprot.WriteI64((long)structs.GetUserId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSvipBindInfoByUserId_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSvipGoodsByMid_argsHelper : TBeanSerializer<getSvipGoodsByMid_args>
		{
			
			public static getSvipGoodsByMid_argsHelper OBJ = new getSvipGoodsByMid_argsHelper();
			
			public static getSvipGoodsByMid_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSvipGoodsByMid_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.GetSvipGoodsRequest value;
					
					value = new com.vip.svip.osp.service.GetSvipGoodsRequest();
					com.vip.svip.osp.service.GetSvipGoodsRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSvipGoodsByMid_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.svip.osp.service.GetSvipGoodsRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSvipGoodsByMid_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSvipGoodsDetail_argsHelper : TBeanSerializer<getSvipGoodsDetail_args>
		{
			
			public static getSvipGoodsDetail_argsHelper OBJ = new getSvipGoodsDetail_argsHelper();
			
			public static getSvipGoodsDetail_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSvipGoodsDetail_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.GetSvipGoodsDetailReq value;
					
					value = new com.vip.svip.osp.service.GetSvipGoodsDetailReq();
					com.vip.svip.osp.service.GetSvipGoodsDetailReqHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSvipGoodsDetail_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.svip.osp.service.GetSvipGoodsDetailReqHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSvipGoodsDetail_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSvipInfo4AppClub_argsHelper : TBeanSerializer<getSvipInfo4AppClub_args>
		{
			
			public static getSvipInfo4AppClub_argsHelper OBJ = new getSvipInfo4AppClub_argsHelper();
			
			public static getSvipInfo4AppClub_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSvipInfo4AppClub_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.GetSvipInfo4AppClubRequest value;
					
					value = new com.vip.svip.osp.service.GetSvipInfo4AppClubRequest();
					com.vip.svip.osp.service.GetSvipInfo4AppClubRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSvipInfo4AppClub_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.svip.osp.service.GetSvipInfo4AppClubRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSvipInfo4AppClub_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSvipMainInfo_argsHelper : TBeanSerializer<getSvipMainInfo_args>
		{
			
			public static getSvipMainInfo_argsHelper OBJ = new getSvipMainInfo_argsHelper();
			
			public static getSvipMainInfo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSvipMainInfo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.BaseRequestHeader value;
					
					value = new com.vip.svip.osp.service.BaseRequestHeader();
					com.vip.svip.osp.service.BaseRequestHeaderHelper.getInstance().Read(value, iprot);
					
					structs.SetHeader(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSvipMainInfo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetHeader() != null) {
					
					oprot.WriteFieldBegin("header");
					
					com.vip.svip.osp.service.BaseRequestHeaderHelper.getInstance().Write(structs.GetHeader(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("header can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSvipMainInfo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSvipUserHealth_argsHelper : TBeanSerializer<getSvipUserHealth_args>
		{
			
			public static getSvipUserHealth_argsHelper OBJ = new getSvipUserHealth_argsHelper();
			
			public static getSvipUserHealth_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSvipUserHealth_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.GetSvipUserHealthReq value;
					
					value = new com.vip.svip.osp.service.GetSvipUserHealthReq();
					com.vip.svip.osp.service.GetSvipUserHealthReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSvipUserHealth_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					com.vip.svip.osp.service.GetSvipUserHealthReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSvipUserHealth_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSvipUserInfo_argsHelper : TBeanSerializer<getSvipUserInfo_args>
		{
			
			public static getSvipUserInfo_argsHelper OBJ = new getSvipUserInfo_argsHelper();
			
			public static getSvipUserInfo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSvipUserInfo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.SvipUserLimitStateReq value;
					
					value = new com.vip.svip.osp.service.SvipUserLimitStateReq();
					com.vip.svip.osp.service.SvipUserLimitStateReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSvipUserInfo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					com.vip.svip.osp.service.SvipUserLimitStateReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSvipUserInfo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getTencentVipSvipCardInfo_argsHelper : TBeanSerializer<getTencentVipSvipCardInfo_args>
		{
			
			public static getTencentVipSvipCardInfo_argsHelper OBJ = new getTencentVipSvipCardInfo_argsHelper();
			
			public static getTencentVipSvipCardInfo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getTencentVipSvipCardInfo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetUserId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getTencentVipSvipCardInfo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetUserId() != null) {
					
					oprot.WriteFieldBegin("userId");
					oprot.WriteI64((long)structs.GetUserId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getTencentVipSvipCardInfo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getTheTimeSvipPrice_argsHelper : TBeanSerializer<getTheTimeSvipPrice_args>
		{
			
			public static getTheTimeSvipPrice_argsHelper OBJ = new getTheTimeSvipPrice_argsHelper();
			
			public static getTheTimeSvipPrice_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getTheTimeSvipPrice_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.GetTheTimeSvipPrice value;
					
					value = new com.vip.svip.osp.service.GetTheTimeSvipPrice();
					com.vip.svip.osp.service.GetTheTimeSvipPriceHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getTheTimeSvipPrice_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.svip.osp.service.GetTheTimeSvipPriceHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getTheTimeSvipPrice_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getUserAttendInfo_argsHelper : TBeanSerializer<getUserAttendInfo_args>
		{
			
			public static getUserAttendInfo_argsHelper OBJ = new getUserAttendInfo_argsHelper();
			
			public static getUserAttendInfo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getUserAttendInfo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.UserAttendInfoRequest value;
					
					value = new com.vip.svip.osp.service.UserAttendInfoRequest();
					com.vip.svip.osp.service.UserAttendInfoRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getUserAttendInfo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.svip.osp.service.UserAttendInfoRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getUserAttendInfo_args bean){
				
				
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
		
		
		
		
		public class isSvipBanArea_argsHelper : TBeanSerializer<isSvipBanArea_args>
		{
			
			public static isSvipBanArea_argsHelper OBJ = new isSvipBanArea_argsHelper();
			
			public static isSvipBanArea_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(isSvipBanArea_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetAreaId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(isSvipBanArea_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetAreaId() != null) {
					
					oprot.WriteFieldBegin("areaId");
					oprot.WriteString(structs.GetAreaId());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(isSvipBanArea_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class isSvipBuyLimit_argsHelper : TBeanSerializer<isSvipBuyLimit_args>
		{
			
			public static isSvipBuyLimit_argsHelper OBJ = new isSvipBuyLimit_argsHelper();
			
			public static isSvipBuyLimit_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(isSvipBuyLimit_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.BuyLimitRequestHeader value;
					
					value = new com.vip.svip.osp.service.BuyLimitRequestHeader();
					com.vip.svip.osp.service.BuyLimitRequestHeaderHelper.getInstance().Read(value, iprot);
					
					structs.SetHeader(value);
				}
				
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.BuyLimitRequestParam value;
					
					value = new com.vip.svip.osp.service.BuyLimitRequestParam();
					com.vip.svip.osp.service.BuyLimitRequestParamHelper.getInstance().Read(value, iprot);
					
					structs.SetParam(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(isSvipBuyLimit_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetHeader() != null) {
					
					oprot.WriteFieldBegin("header");
					
					com.vip.svip.osp.service.BuyLimitRequestHeaderHelper.getInstance().Write(structs.GetHeader(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("header can not be null!");
				}
				
				
				if(structs.GetParam() != null) {
					
					oprot.WriteFieldBegin("param");
					
					com.vip.svip.osp.service.BuyLimitRequestParamHelper.getInstance().Write(structs.GetParam(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("param can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(isSvipBuyLimit_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class isSvipLimitUser_argsHelper : TBeanSerializer<isSvipLimitUser_args>
		{
			
			public static isSvipLimitUser_argsHelper OBJ = new isSvipLimitUser_argsHelper();
			
			public static isSvipLimitUser_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(isSvipLimitUser_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.BuyLimitStateRequest value;
					
					value = new com.vip.svip.osp.service.BuyLimitStateRequest();
					com.vip.svip.osp.service.BuyLimitStateRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(isSvipLimitUser_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.svip.osp.service.BuyLimitStateRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(isSvipLimitUser_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class isSvipLimitUserByPhone_argsHelper : TBeanSerializer<isSvipLimitUserByPhone_args>
		{
			
			public static isSvipLimitUserByPhone_argsHelper OBJ = new isSvipLimitUserByPhone_argsHelper();
			
			public static isSvipLimitUserByPhone_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(isSvipLimitUserByPhone_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.CheckSvipUserLimitByPhoneParam value;
					
					value = new com.vip.svip.osp.service.CheckSvipUserLimitByPhoneParam();
					com.vip.svip.osp.service.CheckSvipUserLimitByPhoneParamHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(isSvipLimitUserByPhone_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.svip.osp.service.CheckSvipUserLimitByPhoneParamHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(isSvipLimitUserByPhone_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class joinSvipForTencentVideoSide_argsHelper : TBeanSerializer<joinSvipForTencentVideoSide_args>
		{
			
			public static joinSvipForTencentVideoSide_argsHelper OBJ = new joinSvipForTencentVideoSide_argsHelper();
			
			public static joinSvipForTencentVideoSide_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(joinSvipForTencentVideoSide_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.DoubleSvipRequest value;
					
					value = new com.vip.svip.osp.service.DoubleSvipRequest();
					com.vip.svip.osp.service.DoubleSvipRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(joinSvipForTencentVideoSide_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.svip.osp.service.DoubleSvipRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(joinSvipForTencentVideoSide_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class joinTencentVideoMemberAtVipSide_argsHelper : TBeanSerializer<joinTencentVideoMemberAtVipSide_args>
		{
			
			public static joinTencentVideoMemberAtVipSide_argsHelper OBJ = new joinTencentVideoMemberAtVipSide_argsHelper();
			
			public static joinTencentVideoMemberAtVipSide_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(joinTencentVideoMemberAtVipSide_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.DoubleSvipRequest value;
					
					value = new com.vip.svip.osp.service.DoubleSvipRequest();
					com.vip.svip.osp.service.DoubleSvipRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(joinTencentVideoMemberAtVipSide_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.svip.osp.service.DoubleSvipRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(joinTencentVideoMemberAtVipSide_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class offlineChannelTrySvip_argsHelper : TBeanSerializer<offlineChannelTrySvip_args>
		{
			
			public static offlineChannelTrySvip_argsHelper OBJ = new offlineChannelTrySvip_argsHelper();
			
			public static offlineChannelTrySvip_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(offlineChannelTrySvip_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.SimpleRequestHeader value;
					
					value = new com.vip.svip.osp.service.SimpleRequestHeader();
					com.vip.svip.osp.service.SimpleRequestHeaderHelper.getInstance().Read(value, iprot);
					
					structs.SetHeader(value);
				}
				
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.OfflineChannelInfo value;
					
					value = new com.vip.svip.osp.service.OfflineChannelInfo();
					com.vip.svip.osp.service.OfflineChannelInfoHelper.getInstance().Read(value, iprot);
					
					structs.SetChannelInfo(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(offlineChannelTrySvip_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetHeader() != null) {
					
					oprot.WriteFieldBegin("header");
					
					com.vip.svip.osp.service.SimpleRequestHeaderHelper.getInstance().Write(structs.GetHeader(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("header can not be null!");
				}
				
				
				if(structs.GetChannelInfo() != null) {
					
					oprot.WriteFieldBegin("channelInfo");
					
					com.vip.svip.osp.service.OfflineChannelInfoHelper.getInstance().Write(structs.GetChannelInfo(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("channelInfo can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(offlineChannelTrySvip_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class openLimitCheck_argsHelper : TBeanSerializer<openLimitCheck_args>
		{
			
			public static openLimitCheck_argsHelper OBJ = new openLimitCheck_argsHelper();
			
			public static openLimitCheck_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(openLimitCheck_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.OpenLimitRequest value;
					
					value = new com.vip.svip.osp.service.OpenLimitRequest();
					com.vip.svip.osp.service.OpenLimitRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(openLimitCheck_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.svip.osp.service.OpenLimitRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(openLimitCheck_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class prepareDoubleSvipAccess_argsHelper : TBeanSerializer<prepareDoubleSvipAccess_args>
		{
			
			public static prepareDoubleSvipAccess_argsHelper OBJ = new prepareDoubleSvipAccess_argsHelper();
			
			public static prepareDoubleSvipAccess_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(prepareDoubleSvipAccess_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.DoubleSvipRequest value;
					
					value = new com.vip.svip.osp.service.DoubleSvipRequest();
					com.vip.svip.osp.service.DoubleSvipRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(prepareDoubleSvipAccess_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.svip.osp.service.DoubleSvipRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(prepareDoubleSvipAccess_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class receivePrize_argsHelper : TBeanSerializer<receivePrize_args>
		{
			
			public static receivePrize_argsHelper OBJ = new receivePrize_argsHelper();
			
			public static receivePrize_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(receivePrize_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.ReceivePrizeRequest value;
					
					value = new com.vip.svip.osp.service.ReceivePrizeRequest();
					com.vip.svip.osp.service.ReceivePrizeRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(receivePrize_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.svip.osp.service.ReceivePrizeRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(receivePrize_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class rejoinTencentMember_argsHelper : TBeanSerializer<rejoinTencentMember_args>
		{
			
			public static rejoinTencentMember_argsHelper OBJ = new rejoinTencentMember_argsHelper();
			
			public static rejoinTencentMember_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(rejoinTencentMember_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSerial(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetAdmin(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(rejoinTencentMember_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSerial() != null) {
					
					oprot.WriteFieldBegin("serial");
					oprot.WriteString(structs.GetSerial());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("serial can not be null!");
				}
				
				
				if(structs.GetAdmin() != null) {
					
					oprot.WriteFieldBegin("admin");
					oprot.WriteString(structs.GetAdmin());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("admin can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(rejoinTencentMember_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class retryOthersOperateRecord_argsHelper : TBeanSerializer<retryOthersOperateRecord_args>
		{
			
			public static retryOthersOperateRecord_argsHelper OBJ = new retryOthersOperateRecord_argsHelper();
			
			public static retryOthersOperateRecord_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(retryOthersOperateRecord_args structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(retryOthersOperateRecord_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(retryOthersOperateRecord_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class retryProcessGifts_argsHelper : TBeanSerializer<retryProcessGifts_args>
		{
			
			public static retryProcessGifts_argsHelper OBJ = new retryProcessGifts_argsHelper();
			
			public static retryProcessGifts_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(retryProcessGifts_args structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(retryProcessGifts_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(retryProcessGifts_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class retrySvipExceptionLog_argsHelper : TBeanSerializer<retrySvipExceptionLog_args>
		{
			
			public static retrySvipExceptionLog_argsHelper OBJ = new retrySvipExceptionLog_argsHelper();
			
			public static retrySvipExceptionLog_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(retrySvipExceptionLog_args structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(retrySvipExceptionLog_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(retrySvipExceptionLog_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class retrySvipOperate_argsHelper : TBeanSerializer<retrySvipOperate_args>
		{
			
			public static retrySvipOperate_argsHelper OBJ = new retrySvipOperate_argsHelper();
			
			public static retrySvipOperate_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(retrySvipOperate_args structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(retrySvipOperate_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(retrySvipOperate_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class scrapeAction_argsHelper : TBeanSerializer<scrapeAction_args>
		{
			
			public static scrapeAction_argsHelper OBJ = new scrapeAction_argsHelper();
			
			public static scrapeAction_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(scrapeAction_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.ScrapeActionRequest value;
					
					value = new com.vip.svip.osp.service.ScrapeActionRequest();
					com.vip.svip.osp.service.ScrapeActionRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(scrapeAction_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.svip.osp.service.ScrapeActionRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(scrapeAction_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class searchSvipTXHistory_argsHelper : TBeanSerializer<searchSvipTXHistory_args>
		{
			
			public static searchSvipTXHistory_argsHelper OBJ = new searchSvipTXHistory_argsHelper();
			
			public static searchSvipTXHistory_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(searchSvipTXHistory_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.SearchSvipHistoryRequest value;
					
					value = new com.vip.svip.osp.service.SearchSvipHistoryRequest();
					com.vip.svip.osp.service.SearchSvipHistoryRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(searchSvipTXHistory_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.svip.osp.service.SearchSvipHistoryRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(searchSvipTXHistory_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class specialMemberTrySvip_argsHelper : TBeanSerializer<specialMemberTrySvip_args>
		{
			
			public static specialMemberTrySvip_argsHelper OBJ = new specialMemberTrySvip_argsHelper();
			
			public static specialMemberTrySvip_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(specialMemberTrySvip_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.SimpleRequestHeader value;
					
					value = new com.vip.svip.osp.service.SimpleRequestHeader();
					com.vip.svip.osp.service.SimpleRequestHeaderHelper.getInstance().Read(value, iprot);
					
					structs.SetHeader(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(specialMemberTrySvip_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetHeader() != null) {
					
					oprot.WriteFieldBegin("header");
					
					com.vip.svip.osp.service.SimpleRequestHeaderHelper.getInstance().Write(structs.GetHeader(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("header can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(specialMemberTrySvip_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class svipUserOperate_argsHelper : TBeanSerializer<svipUserOperate_args>
		{
			
			public static svipUserOperate_argsHelper OBJ = new svipUserOperate_argsHelper();
			
			public static svipUserOperate_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(svipUserOperate_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.SvipUserOperateInfoParam value;
					
					value = new com.vip.svip.osp.service.SvipUserOperateInfoParam();
					com.vip.svip.osp.service.SvipUserOperateInfoParamHelper.getInstance().Read(value, iprot);
					
					structs.SetInfo(value);
				}
				
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.SvipUserOperateSignCheck value;
					
					value = new com.vip.svip.osp.service.SvipUserOperateSignCheck();
					com.vip.svip.osp.service.SvipUserOperateSignCheckHelper.getInstance().Read(value, iprot);
					
					structs.SetSignCheck(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(svipUserOperate_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetInfo() != null) {
					
					oprot.WriteFieldBegin("info");
					
					com.vip.svip.osp.service.SvipUserOperateInfoParamHelper.getInstance().Write(structs.GetInfo(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("info can not be null!");
				}
				
				
				if(structs.GetSignCheck() != null) {
					
					oprot.WriteFieldBegin("signCheck");
					
					com.vip.svip.osp.service.SvipUserOperateSignCheckHelper.getInstance().Write(structs.GetSignCheck(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("signCheck can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(svipUserOperate_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class syncCancelResult_argsHelper : TBeanSerializer<syncCancelResult_args>
		{
			
			public static syncCancelResult_argsHelper OBJ = new syncCancelResult_argsHelper();
			
			public static syncCancelResult_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(syncCancelResult_args structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(syncCancelResult_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(syncCancelResult_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class txGetSvipToken_argsHelper : TBeanSerializer<txGetSvipToken_args>
		{
			
			public static txGetSvipToken_argsHelper OBJ = new txGetSvipToken_argsHelper();
			
			public static txGetSvipToken_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(txGetSvipToken_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.TxGetTokenRequest value;
					
					value = new com.vip.svip.osp.service.TxGetTokenRequest();
					com.vip.svip.osp.service.TxGetTokenRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(txGetSvipToken_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.svip.osp.service.TxGetTokenRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(txGetSvipToken_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class txOpenSvip_argsHelper : TBeanSerializer<txOpenSvip_args>
		{
			
			public static txOpenSvip_argsHelper OBJ = new txOpenSvip_argsHelper();
			
			public static txOpenSvip_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(txOpenSvip_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.TxOpenSvipRequest value;
					
					value = new com.vip.svip.osp.service.TxOpenSvipRequest();
					com.vip.svip.osp.service.TxOpenSvipRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(txOpenSvip_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.svip.osp.service.TxOpenSvipRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(txOpenSvip_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class vOrderCallSvip_argsHelper : TBeanSerializer<vOrderCallSvip_args>
		{
			
			public static vOrderCallSvip_argsHelper OBJ = new vOrderCallSvip_argsHelper();
			
			public static vOrderCallSvip_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(vOrderCallSvip_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetJson(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(vOrderCallSvip_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetJson() != null) {
					
					oprot.WriteFieldBegin("json");
					oprot.WriteString(structs.GetJson());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(vOrderCallSvip_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class SearchSvipHistory_resultHelper : TBeanSerializer<SearchSvipHistory_result>
		{
			
			public static SearchSvipHistory_resultHelper OBJ = new SearchSvipHistory_resultHelper();
			
			public static SearchSvipHistory_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(SearchSvipHistory_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.svip.osp.service.SearchSvipHistoryResult> value;
					
					value = new List<com.vip.svip.osp.service.SearchSvipHistoryResult>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.svip.osp.service.SearchSvipHistoryResult elem0;
							
							elem0 = new com.vip.svip.osp.service.SearchSvipHistoryResult();
							com.vip.svip.osp.service.SearchSvipHistoryResultHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(SearchSvipHistory_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.svip.osp.service.SearchSvipHistoryResult _item0 in structs.GetSuccess()){
						
						
						com.vip.svip.osp.service.SearchSvipHistoryResultHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(SearchSvipHistory_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchCancel_resultHelper : TBeanSerializer<batchCancel_result>
		{
			
			public static batchCancel_resultHelper OBJ = new batchCancel_resultHelper();
			
			public static batchCancel_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchCancel_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.BatchCancelBaseResult value;
					
					value = new com.vip.svip.osp.service.BatchCancelBaseResult();
					com.vip.svip.osp.service.BatchCancelBaseResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(batchCancel_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.svip.osp.service.BatchCancelBaseResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchCancel_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchCancelV2_resultHelper : TBeanSerializer<batchCancelV2_result>
		{
			
			public static batchCancelV2_resultHelper OBJ = new batchCancelV2_resultHelper();
			
			public static batchCancelV2_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchCancelV2_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.BatchCancelBaseResult value;
					
					value = new com.vip.svip.osp.service.BatchCancelBaseResult();
					com.vip.svip.osp.service.BatchCancelBaseResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(batchCancelV2_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.svip.osp.service.BatchCancelBaseResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchCancelV2_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class bindTxUserAccount_resultHelper : TBeanSerializer<bindTxUserAccount_result>
		{
			
			public static bindTxUserAccount_resultHelper OBJ = new bindTxUserAccount_resultHelper();
			
			public static bindTxUserAccount_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(bindTxUserAccount_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.BaseResult value;
					
					value = new com.vip.svip.osp.service.BaseResult();
					com.vip.svip.osp.service.BaseResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(bindTxUserAccount_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.svip.osp.service.BaseResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(bindTxUserAccount_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class brandGiftDetailList_resultHelper : TBeanSerializer<brandGiftDetailList_result>
		{
			
			public static brandGiftDetailList_resultHelper OBJ = new brandGiftDetailList_resultHelper();
			
			public static brandGiftDetailList_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(brandGiftDetailList_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.svip.osp.service.BrandGiftItem> value;
					
					value = new List<com.vip.svip.osp.service.BrandGiftItem>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.svip.osp.service.BrandGiftItem elem0;
							
							elem0 = new com.vip.svip.osp.service.BrandGiftItem();
							com.vip.svip.osp.service.BrandGiftItemHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(brandGiftDetailList_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.svip.osp.service.BrandGiftItem _item0 in structs.GetSuccess()){
						
						
						com.vip.svip.osp.service.BrandGiftItemHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(brandGiftDetailList_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class checkTxAccLimit_resultHelper : TBeanSerializer<checkTxAccLimit_result>
		{
			
			public static checkTxAccLimit_resultHelper OBJ = new checkTxAccLimit_resultHelper();
			
			public static checkTxAccLimit_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(checkTxAccLimit_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.BaseResult value;
					
					value = new com.vip.svip.osp.service.BaseResult();
					com.vip.svip.osp.service.BaseResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(checkTxAccLimit_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.svip.osp.service.BaseResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(checkTxAccLimit_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class doCancelJob_resultHelper : TBeanSerializer<doCancelJob_result>
		{
			
			public static doCancelJob_resultHelper OBJ = new doCancelJob_resultHelper();
			
			public static doCancelJob_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(doCancelJob_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.BaseResult value;
					
					value = new com.vip.svip.osp.service.BaseResult();
					com.vip.svip.osp.service.BaseResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(doCancelJob_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.svip.osp.service.BaseResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(doCancelJob_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class doCancelSvipUser_resultHelper : TBeanSerializer<doCancelSvipUser_result>
		{
			
			public static doCancelSvipUser_resultHelper OBJ = new doCancelSvipUser_resultHelper();
			
			public static doCancelSvipUser_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(doCancelSvipUser_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.BaseResult value;
					
					value = new com.vip.svip.osp.service.BaseResult();
					com.vip.svip.osp.service.BaseResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(doCancelSvipUser_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.svip.osp.service.BaseResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(doCancelSvipUser_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class draw_resultHelper : TBeanSerializer<draw_result>
		{
			
			public static draw_resultHelper OBJ = new draw_resultHelper();
			
			public static draw_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(draw_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(draw_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteString(structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(draw_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getBindAccountInfo_resultHelper : TBeanSerializer<getBindAccountInfo_result>
		{
			
			public static getBindAccountInfo_resultHelper OBJ = new getBindAccountInfo_resultHelper();
			
			public static getBindAccountInfo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getBindAccountInfo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.AccountInfoResult value;
					
					value = new com.vip.svip.osp.service.AccountInfoResult();
					com.vip.svip.osp.service.AccountInfoResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getBindAccountInfo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.svip.osp.service.AccountInfoResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getBindAccountInfo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getBrandGiftIdList_resultHelper : TBeanSerializer<getBrandGiftIdList_result>
		{
			
			public static getBrandGiftIdList_resultHelper OBJ = new getBrandGiftIdList_resultHelper();
			
			public static getBrandGiftIdList_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getBrandGiftIdList_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.BrandGiftIdResult value;
					
					value = new com.vip.svip.osp.service.BrandGiftIdResult();
					com.vip.svip.osp.service.BrandGiftIdResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getBrandGiftIdList_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.svip.osp.service.BrandGiftIdResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getBrandGiftIdList_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getBuyLimitResult_resultHelper : TBeanSerializer<getBuyLimitResult_result>
		{
			
			public static getBuyLimitResult_resultHelper OBJ = new getBuyLimitResult_resultHelper();
			
			public static getBuyLimitResult_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getBuyLimitResult_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.BuyLimitResult value;
					
					value = new com.vip.svip.osp.service.BuyLimitResult();
					com.vip.svip.osp.service.BuyLimitResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getBuyLimitResult_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.svip.osp.service.BuyLimitResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getBuyLimitResult_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getGoodsIdByPickNo_resultHelper : TBeanSerializer<getGoodsIdByPickNo_result>
		{
			
			public static getGoodsIdByPickNo_resultHelper OBJ = new getGoodsIdByPickNo_resultHelper();
			
			public static getGoodsIdByPickNo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getGoodsIdByPickNo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.GetGoodsIdByPickNoResult value;
					
					value = new com.vip.svip.osp.service.GetGoodsIdByPickNoResult();
					com.vip.svip.osp.service.GetGoodsIdByPickNoResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getGoodsIdByPickNo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.svip.osp.service.GetGoodsIdByPickNoResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getGoodsIdByPickNo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getGroupValuesConf_resultHelper : TBeanSerializer<getGroupValuesConf_result>
		{
			
			public static getGroupValuesConf_resultHelper OBJ = new getGroupValuesConf_resultHelper();
			
			public static getGroupValuesConf_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getGroupValuesConf_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.svip.osp.service.GroupValues> value;
					
					value = new List<com.vip.svip.osp.service.GroupValues>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.svip.osp.service.GroupValues elem0;
							
							elem0 = new com.vip.svip.osp.service.GroupValues();
							com.vip.svip.osp.service.GroupValuesHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(getGroupValuesConf_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.svip.osp.service.GroupValues _item0 in structs.GetSuccess()){
						
						
						com.vip.svip.osp.service.GroupValuesHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getGroupValuesConf_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getOpGoodsDetailList_resultHelper : TBeanSerializer<getOpGoodsDetailList_result>
		{
			
			public static getOpGoodsDetailList_resultHelper OBJ = new getOpGoodsDetailList_resultHelper();
			
			public static getOpGoodsDetailList_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOpGoodsDetailList_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.GetOpGoodsDetailResult value;
					
					value = new com.vip.svip.osp.service.GetOpGoodsDetailResult();
					com.vip.svip.osp.service.GetOpGoodsDetailResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getOpGoodsDetailList_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.svip.osp.service.GetOpGoodsDetailResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOpGoodsDetailList_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getOpGoodsIds_resultHelper : TBeanSerializer<getOpGoodsIds_result>
		{
			
			public static getOpGoodsIds_resultHelper OBJ = new getOpGoodsIds_resultHelper();
			
			public static getOpGoodsIds_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOpGoodsIds_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.GetOpGoodsIdResult value;
					
					value = new com.vip.svip.osp.service.GetOpGoodsIdResult();
					com.vip.svip.osp.service.GetOpGoodsIdResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getOpGoodsIds_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.svip.osp.service.GetOpGoodsIdResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOpGoodsIds_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPmsPriceByProductId_resultHelper : TBeanSerializer<getPmsPriceByProductId_result>
		{
			
			public static getPmsPriceByProductId_resultHelper OBJ = new getPmsPriceByProductId_resultHelper();
			
			public static getPmsPriceByProductId_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPmsPriceByProductId_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.BrandGoodsPriceResult value;
					
					value = new com.vip.svip.osp.service.BrandGoodsPriceResult();
					com.vip.svip.osp.service.BrandGoodsPriceResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getPmsPriceByProductId_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.svip.osp.service.BrandGoodsPriceResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPmsPriceByProductId_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSumCount_resultHelper : TBeanSerializer<getSumCount_result>
		{
			
			public static getSumCount_resultHelper OBJ = new getSumCount_resultHelper();
			
			public static getSumCount_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSumCount_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSumCount_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteString(structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSumCount_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSvipBindInfo_resultHelper : TBeanSerializer<getSvipBindInfo_result>
		{
			
			public static getSvipBindInfo_resultHelper OBJ = new getSvipBindInfo_resultHelper();
			
			public static getSvipBindInfo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSvipBindInfo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSvipBindInfo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteString(structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSvipBindInfo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSvipBindInfoByUserId_resultHelper : TBeanSerializer<getSvipBindInfoByUserId_result>
		{
			
			public static getSvipBindInfoByUserId_resultHelper OBJ = new getSvipBindInfoByUserId_resultHelper();
			
			public static getSvipBindInfoByUserId_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSvipBindInfoByUserId_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.svip.osp.service.SvipBindInfo> value;
					
					value = new List<com.vip.svip.osp.service.SvipBindInfo>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.svip.osp.service.SvipBindInfo elem0;
							
							elem0 = new com.vip.svip.osp.service.SvipBindInfo();
							com.vip.svip.osp.service.SvipBindInfoHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(getSvipBindInfoByUserId_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.svip.osp.service.SvipBindInfo _item0 in structs.GetSuccess()){
						
						
						com.vip.svip.osp.service.SvipBindInfoHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSvipBindInfoByUserId_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSvipGoodsByMid_resultHelper : TBeanSerializer<getSvipGoodsByMid_result>
		{
			
			public static getSvipGoodsByMid_resultHelper OBJ = new getSvipGoodsByMid_resultHelper();
			
			public static getSvipGoodsByMid_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSvipGoodsByMid_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.GetSvipGoodsResult value;
					
					value = new com.vip.svip.osp.service.GetSvipGoodsResult();
					com.vip.svip.osp.service.GetSvipGoodsResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSvipGoodsByMid_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.svip.osp.service.GetSvipGoodsResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSvipGoodsByMid_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSvipGoodsDetail_resultHelper : TBeanSerializer<getSvipGoodsDetail_result>
		{
			
			public static getSvipGoodsDetail_resultHelper OBJ = new getSvipGoodsDetail_resultHelper();
			
			public static getSvipGoodsDetail_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSvipGoodsDetail_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.GetSvipGoodsDetailResult value;
					
					value = new com.vip.svip.osp.service.GetSvipGoodsDetailResult();
					com.vip.svip.osp.service.GetSvipGoodsDetailResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSvipGoodsDetail_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.svip.osp.service.GetSvipGoodsDetailResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSvipGoodsDetail_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSvipInfo4AppClub_resultHelper : TBeanSerializer<getSvipInfo4AppClub_result>
		{
			
			public static getSvipInfo4AppClub_resultHelper OBJ = new getSvipInfo4AppClub_resultHelper();
			
			public static getSvipInfo4AppClub_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSvipInfo4AppClub_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.GetSvipInfo4AppClubResult value;
					
					value = new com.vip.svip.osp.service.GetSvipInfo4AppClubResult();
					com.vip.svip.osp.service.GetSvipInfo4AppClubResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSvipInfo4AppClub_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.svip.osp.service.GetSvipInfo4AppClubResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSvipInfo4AppClub_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSvipMainInfo_resultHelper : TBeanSerializer<getSvipMainInfo_result>
		{
			
			public static getSvipMainInfo_resultHelper OBJ = new getSvipMainInfo_resultHelper();
			
			public static getSvipMainInfo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSvipMainInfo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.KTBaseInfoResult value;
					
					value = new com.vip.svip.osp.service.KTBaseInfoResult();
					com.vip.svip.osp.service.KTBaseInfoResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSvipMainInfo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.svip.osp.service.KTBaseInfoResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSvipMainInfo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSvipUserHealth_resultHelper : TBeanSerializer<getSvipUserHealth_result>
		{
			
			public static getSvipUserHealth_resultHelper OBJ = new getSvipUserHealth_resultHelper();
			
			public static getSvipUserHealth_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSvipUserHealth_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.SvipUserHealthResp value;
					
					value = new com.vip.svip.osp.service.SvipUserHealthResp();
					com.vip.svip.osp.service.SvipUserHealthRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSvipUserHealth_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.svip.osp.service.SvipUserHealthRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSvipUserHealth_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSvipUserInfo_resultHelper : TBeanSerializer<getSvipUserInfo_result>
		{
			
			public static getSvipUserInfo_resultHelper OBJ = new getSvipUserInfo_resultHelper();
			
			public static getSvipUserInfo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSvipUserInfo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.SvipUserLimitStateResp value;
					
					value = new com.vip.svip.osp.service.SvipUserLimitStateResp();
					com.vip.svip.osp.service.SvipUserLimitStateRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSvipUserInfo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.svip.osp.service.SvipUserLimitStateRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSvipUserInfo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getTencentVipSvipCardInfo_resultHelper : TBeanSerializer<getTencentVipSvipCardInfo_result>
		{
			
			public static getTencentVipSvipCardInfo_resultHelper OBJ = new getTencentVipSvipCardInfo_resultHelper();
			
			public static getTencentVipSvipCardInfo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getTencentVipSvipCardInfo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.TencentSvipGoodsInfo value;
					
					value = new com.vip.svip.osp.service.TencentSvipGoodsInfo();
					com.vip.svip.osp.service.TencentSvipGoodsInfoHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getTencentVipSvipCardInfo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.svip.osp.service.TencentSvipGoodsInfoHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getTencentVipSvipCardInfo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getTheTimeSvipPrice_resultHelper : TBeanSerializer<getTheTimeSvipPrice_result>
		{
			
			public static getTheTimeSvipPrice_resultHelper OBJ = new getTheTimeSvipPrice_resultHelper();
			
			public static getTheTimeSvipPrice_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getTheTimeSvipPrice_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.GetTheTimeSvipPriceResult value;
					
					value = new com.vip.svip.osp.service.GetTheTimeSvipPriceResult();
					com.vip.svip.osp.service.GetTheTimeSvipPriceResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getTheTimeSvipPrice_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.svip.osp.service.GetTheTimeSvipPriceResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getTheTimeSvipPrice_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getUserAttendInfo_resultHelper : TBeanSerializer<getUserAttendInfo_result>
		{
			
			public static getUserAttendInfo_resultHelper OBJ = new getUserAttendInfo_resultHelper();
			
			public static getUserAttendInfo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getUserAttendInfo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getUserAttendInfo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteString(structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getUserAttendInfo_result bean){
				
				
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
		
		
		
		
		public class isSvipBanArea_resultHelper : TBeanSerializer<isSvipBanArea_result>
		{
			
			public static isSvipBanArea_resultHelper OBJ = new isSvipBanArea_resultHelper();
			
			public static isSvipBanArea_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(isSvipBanArea_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(isSvipBanArea_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteString(structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(isSvipBanArea_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class isSvipBuyLimit_resultHelper : TBeanSerializer<isSvipBuyLimit_result>
		{
			
			public static isSvipBuyLimit_resultHelper OBJ = new isSvipBuyLimit_resultHelper();
			
			public static isSvipBuyLimit_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(isSvipBuyLimit_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.BuyLimitResult value;
					
					value = new com.vip.svip.osp.service.BuyLimitResult();
					com.vip.svip.osp.service.BuyLimitResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(isSvipBuyLimit_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.svip.osp.service.BuyLimitResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(isSvipBuyLimit_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class isSvipLimitUser_resultHelper : TBeanSerializer<isSvipLimitUser_result>
		{
			
			public static isSvipLimitUser_resultHelper OBJ = new isSvipLimitUser_resultHelper();
			
			public static isSvipLimitUser_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(isSvipLimitUser_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.BuyLimitState value;
					
					value = new com.vip.svip.osp.service.BuyLimitState();
					com.vip.svip.osp.service.BuyLimitStateHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(isSvipLimitUser_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.svip.osp.service.BuyLimitStateHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(isSvipLimitUser_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class isSvipLimitUserByPhone_resultHelper : TBeanSerializer<isSvipLimitUserByPhone_result>
		{
			
			public static isSvipLimitUserByPhone_resultHelper OBJ = new isSvipLimitUserByPhone_resultHelper();
			
			public static isSvipLimitUserByPhone_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(isSvipLimitUserByPhone_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.BuyLimitState value;
					
					value = new com.vip.svip.osp.service.BuyLimitState();
					com.vip.svip.osp.service.BuyLimitStateHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(isSvipLimitUserByPhone_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.svip.osp.service.BuyLimitStateHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(isSvipLimitUserByPhone_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class joinSvipForTencentVideoSide_resultHelper : TBeanSerializer<joinSvipForTencentVideoSide_result>
		{
			
			public static joinSvipForTencentVideoSide_resultHelper OBJ = new joinSvipForTencentVideoSide_resultHelper();
			
			public static joinSvipForTencentVideoSide_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(joinSvipForTencentVideoSide_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.DoubleSvipCreateResponse value;
					
					value = new com.vip.svip.osp.service.DoubleSvipCreateResponse();
					com.vip.svip.osp.service.DoubleSvipCreateResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(joinSvipForTencentVideoSide_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.svip.osp.service.DoubleSvipCreateResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(joinSvipForTencentVideoSide_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class joinTencentVideoMemberAtVipSide_resultHelper : TBeanSerializer<joinTencentVideoMemberAtVipSide_result>
		{
			
			public static joinTencentVideoMemberAtVipSide_resultHelper OBJ = new joinTencentVideoMemberAtVipSide_resultHelper();
			
			public static joinTencentVideoMemberAtVipSide_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(joinTencentVideoMemberAtVipSide_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.BaseResult value;
					
					value = new com.vip.svip.osp.service.BaseResult();
					com.vip.svip.osp.service.BaseResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(joinTencentVideoMemberAtVipSide_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.svip.osp.service.BaseResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(joinTencentVideoMemberAtVipSide_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class offlineChannelTrySvip_resultHelper : TBeanSerializer<offlineChannelTrySvip_result>
		{
			
			public static offlineChannelTrySvip_resultHelper OBJ = new offlineChannelTrySvip_resultHelper();
			
			public static offlineChannelTrySvip_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(offlineChannelTrySvip_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.BaseResult value;
					
					value = new com.vip.svip.osp.service.BaseResult();
					com.vip.svip.osp.service.BaseResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(offlineChannelTrySvip_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.svip.osp.service.BaseResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(offlineChannelTrySvip_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class openLimitCheck_resultHelper : TBeanSerializer<openLimitCheck_result>
		{
			
			public static openLimitCheck_resultHelper OBJ = new openLimitCheck_resultHelper();
			
			public static openLimitCheck_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(openLimitCheck_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.BuyLimitResult value;
					
					value = new com.vip.svip.osp.service.BuyLimitResult();
					com.vip.svip.osp.service.BuyLimitResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(openLimitCheck_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.svip.osp.service.BuyLimitResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(openLimitCheck_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class prepareDoubleSvipAccess_resultHelper : TBeanSerializer<prepareDoubleSvipAccess_result>
		{
			
			public static prepareDoubleSvipAccess_resultHelper OBJ = new prepareDoubleSvipAccess_resultHelper();
			
			public static prepareDoubleSvipAccess_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(prepareDoubleSvipAccess_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.DoubleSvipStatus value;
					
					value = new com.vip.svip.osp.service.DoubleSvipStatus();
					com.vip.svip.osp.service.DoubleSvipStatusHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(prepareDoubleSvipAccess_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.svip.osp.service.DoubleSvipStatusHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(prepareDoubleSvipAccess_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class receivePrize_resultHelper : TBeanSerializer<receivePrize_result>
		{
			
			public static receivePrize_resultHelper OBJ = new receivePrize_resultHelper();
			
			public static receivePrize_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(receivePrize_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(receivePrize_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteString(structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(receivePrize_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class rejoinTencentMember_resultHelper : TBeanSerializer<rejoinTencentMember_result>
		{
			
			public static rejoinTencentMember_resultHelper OBJ = new rejoinTencentMember_resultHelper();
			
			public static rejoinTencentMember_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(rejoinTencentMember_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.BaseResult value;
					
					value = new com.vip.svip.osp.service.BaseResult();
					com.vip.svip.osp.service.BaseResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(rejoinTencentMember_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.svip.osp.service.BaseResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(rejoinTencentMember_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class retryOthersOperateRecord_resultHelper : TBeanSerializer<retryOthersOperateRecord_result>
		{
			
			public static retryOthersOperateRecord_resultHelper OBJ = new retryOthersOperateRecord_resultHelper();
			
			public static retryOthersOperateRecord_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(retryOthersOperateRecord_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(retryOthersOperateRecord_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(retryOthersOperateRecord_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class retryProcessGifts_resultHelper : TBeanSerializer<retryProcessGifts_result>
		{
			
			public static retryProcessGifts_resultHelper OBJ = new retryProcessGifts_resultHelper();
			
			public static retryProcessGifts_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(retryProcessGifts_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(retryProcessGifts_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(retryProcessGifts_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class retrySvipExceptionLog_resultHelper : TBeanSerializer<retrySvipExceptionLog_result>
		{
			
			public static retrySvipExceptionLog_resultHelper OBJ = new retrySvipExceptionLog_resultHelper();
			
			public static retrySvipExceptionLog_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(retrySvipExceptionLog_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(retrySvipExceptionLog_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(retrySvipExceptionLog_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class retrySvipOperate_resultHelper : TBeanSerializer<retrySvipOperate_result>
		{
			
			public static retrySvipOperate_resultHelper OBJ = new retrySvipOperate_resultHelper();
			
			public static retrySvipOperate_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(retrySvipOperate_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(retrySvipOperate_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(retrySvipOperate_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class scrapeAction_resultHelper : TBeanSerializer<scrapeAction_result>
		{
			
			public static scrapeAction_resultHelper OBJ = new scrapeAction_resultHelper();
			
			public static scrapeAction_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(scrapeAction_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(scrapeAction_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteString(structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(scrapeAction_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class searchSvipTXHistory_resultHelper : TBeanSerializer<searchSvipTXHistory_result>
		{
			
			public static searchSvipTXHistory_resultHelper OBJ = new searchSvipTXHistory_resultHelper();
			
			public static searchSvipTXHistory_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(searchSvipTXHistory_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.SvipTXBindHistoryResult value;
					
					value = new com.vip.svip.osp.service.SvipTXBindHistoryResult();
					com.vip.svip.osp.service.SvipTXBindHistoryResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(searchSvipTXHistory_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.svip.osp.service.SvipTXBindHistoryResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(searchSvipTXHistory_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class specialMemberTrySvip_resultHelper : TBeanSerializer<specialMemberTrySvip_result>
		{
			
			public static specialMemberTrySvip_resultHelper OBJ = new specialMemberTrySvip_resultHelper();
			
			public static specialMemberTrySvip_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(specialMemberTrySvip_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.BaseResult value;
					
					value = new com.vip.svip.osp.service.BaseResult();
					com.vip.svip.osp.service.BaseResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(specialMemberTrySvip_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.svip.osp.service.BaseResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(specialMemberTrySvip_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class svipUserOperate_resultHelper : TBeanSerializer<svipUserOperate_result>
		{
			
			public static svipUserOperate_resultHelper OBJ = new svipUserOperate_resultHelper();
			
			public static svipUserOperate_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(svipUserOperate_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.SvipOperateResult value;
					
					value = new com.vip.svip.osp.service.SvipOperateResult();
					com.vip.svip.osp.service.SvipOperateResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(svipUserOperate_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.svip.osp.service.SvipOperateResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(svipUserOperate_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class syncCancelResult_resultHelper : TBeanSerializer<syncCancelResult_result>
		{
			
			public static syncCancelResult_resultHelper OBJ = new syncCancelResult_resultHelper();
			
			public static syncCancelResult_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(syncCancelResult_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(syncCancelResult_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(syncCancelResult_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class txGetSvipToken_resultHelper : TBeanSerializer<txGetSvipToken_result>
		{
			
			public static txGetSvipToken_resultHelper OBJ = new txGetSvipToken_resultHelper();
			
			public static txGetSvipToken_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(txGetSvipToken_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.TxGetSvipTokenResult value;
					
					value = new com.vip.svip.osp.service.TxGetSvipTokenResult();
					com.vip.svip.osp.service.TxGetSvipTokenResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(txGetSvipToken_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.svip.osp.service.TxGetSvipTokenResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(txGetSvipToken_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class txOpenSvip_resultHelper : TBeanSerializer<txOpenSvip_result>
		{
			
			public static txOpenSvip_resultHelper OBJ = new txOpenSvip_resultHelper();
			
			public static txOpenSvip_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(txOpenSvip_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.DoubleSvipCreateResponse value;
					
					value = new com.vip.svip.osp.service.DoubleSvipCreateResponse();
					com.vip.svip.osp.service.DoubleSvipCreateResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(txOpenSvip_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.svip.osp.service.DoubleSvipCreateResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(txOpenSvip_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class vOrderCallSvip_resultHelper : TBeanSerializer<vOrderCallSvip_result>
		{
			
			public static vOrderCallSvip_resultHelper OBJ = new vOrderCallSvip_resultHelper();
			
			public static vOrderCallSvip_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(vOrderCallSvip_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.svip.osp.service.SvipOperateResult value;
					
					value = new com.vip.svip.osp.service.SvipOperateResult();
					com.vip.svip.osp.service.SvipOperateResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(vOrderCallSvip_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.svip.osp.service.SvipOperateResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(vOrderCallSvip_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class SvipOspServiceV2Client : OspRestStub , SvipOspServiceV2  {
			
			
			public SvipOspServiceV2Client():base("com.vip.svip.osp.service.SvipOspServiceV2","1.0.0") {
				
				
			}
			
			
			
			public List<com.vip.svip.osp.service.SearchSvipHistoryResult> SearchSvipHistory(com.vip.svip.osp.service.SearchSvipHistoryRequest request_) {
				
				send_SearchSvipHistory(request_);
				return recv_SearchSvipHistory(); 
				
			}
			
			
			private void send_SearchSvipHistory(com.vip.svip.osp.service.SearchSvipHistoryRequest request_){
				
				InitInvocation("SearchSvipHistory");
				
				SearchSvipHistory_args args = new SearchSvipHistory_args();
				args.SetRequest(request_);
				
				SendBase(args, SearchSvipHistory_argsHelper.getInstance());
			}
			
			
			private List<com.vip.svip.osp.service.SearchSvipHistoryResult> recv_SearchSvipHistory(){
				
				SearchSvipHistory_result result = new SearchSvipHistory_result();
				ReceiveBase(result, SearchSvipHistory_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.svip.osp.service.BatchCancelBaseResult batchCancel(com.vip.svip.osp.service.BatchCancelRequest request_) {
				
				send_batchCancel(request_);
				return recv_batchCancel(); 
				
			}
			
			
			private void send_batchCancel(com.vip.svip.osp.service.BatchCancelRequest request_){
				
				InitInvocation("batchCancel");
				
				batchCancel_args args = new batchCancel_args();
				args.SetRequest(request_);
				
				SendBase(args, batchCancel_argsHelper.getInstance());
			}
			
			
			private com.vip.svip.osp.service.BatchCancelBaseResult recv_batchCancel(){
				
				batchCancel_result result = new batchCancel_result();
				ReceiveBase(result, batchCancel_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.svip.osp.service.BatchCancelBaseResult batchCancelV2(com.vip.svip.osp.service.BatchCancelRequestV2 request_) {
				
				send_batchCancelV2(request_);
				return recv_batchCancelV2(); 
				
			}
			
			
			private void send_batchCancelV2(com.vip.svip.osp.service.BatchCancelRequestV2 request_){
				
				InitInvocation("batchCancelV2");
				
				batchCancelV2_args args = new batchCancelV2_args();
				args.SetRequest(request_);
				
				SendBase(args, batchCancelV2_argsHelper.getInstance());
			}
			
			
			private com.vip.svip.osp.service.BatchCancelBaseResult recv_batchCancelV2(){
				
				batchCancelV2_result result = new batchCancelV2_result();
				ReceiveBase(result, batchCancelV2_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.svip.osp.service.BaseResult bindTxUserAccount(com.vip.svip.osp.service.BindTxAccRequest request_) {
				
				send_bindTxUserAccount(request_);
				return recv_bindTxUserAccount(); 
				
			}
			
			
			private void send_bindTxUserAccount(com.vip.svip.osp.service.BindTxAccRequest request_){
				
				InitInvocation("bindTxUserAccount");
				
				bindTxUserAccount_args args = new bindTxUserAccount_args();
				args.SetRequest(request_);
				
				SendBase(args, bindTxUserAccount_argsHelper.getInstance());
			}
			
			
			private com.vip.svip.osp.service.BaseResult recv_bindTxUserAccount(){
				
				bindTxUserAccount_result result = new bindTxUserAccount_result();
				ReceiveBase(result, bindTxUserAccount_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.svip.osp.service.BrandGiftItem> brandGiftDetailList(com.vip.svip.osp.service.BrandGiftDetailRequest request_) {
				
				send_brandGiftDetailList(request_);
				return recv_brandGiftDetailList(); 
				
			}
			
			
			private void send_brandGiftDetailList(com.vip.svip.osp.service.BrandGiftDetailRequest request_){
				
				InitInvocation("brandGiftDetailList");
				
				brandGiftDetailList_args args = new brandGiftDetailList_args();
				args.SetRequest(request_);
				
				SendBase(args, brandGiftDetailList_argsHelper.getInstance());
			}
			
			
			private List<com.vip.svip.osp.service.BrandGiftItem> recv_brandGiftDetailList(){
				
				brandGiftDetailList_result result = new brandGiftDetailList_result();
				ReceiveBase(result, brandGiftDetailList_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.svip.osp.service.BaseResult checkTxAccLimit(com.vip.svip.osp.service.CheckTxAccLimitRequest request_) {
				
				send_checkTxAccLimit(request_);
				return recv_checkTxAccLimit(); 
				
			}
			
			
			private void send_checkTxAccLimit(com.vip.svip.osp.service.CheckTxAccLimitRequest request_){
				
				InitInvocation("checkTxAccLimit");
				
				checkTxAccLimit_args args = new checkTxAccLimit_args();
				args.SetRequest(request_);
				
				SendBase(args, checkTxAccLimit_argsHelper.getInstance());
			}
			
			
			private com.vip.svip.osp.service.BaseResult recv_checkTxAccLimit(){
				
				checkTxAccLimit_result result = new checkTxAccLimit_result();
				ReceiveBase(result, checkTxAccLimit_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.svip.osp.service.BaseResult doCancelJob(com.vip.svip.osp.service.DoCancelJobRequest request_) {
				
				send_doCancelJob(request_);
				return recv_doCancelJob(); 
				
			}
			
			
			private void send_doCancelJob(com.vip.svip.osp.service.DoCancelJobRequest request_){
				
				InitInvocation("doCancelJob");
				
				doCancelJob_args args = new doCancelJob_args();
				args.SetRequest(request_);
				
				SendBase(args, doCancelJob_argsHelper.getInstance());
			}
			
			
			private com.vip.svip.osp.service.BaseResult recv_doCancelJob(){
				
				doCancelJob_result result = new doCancelJob_result();
				ReceiveBase(result, doCancelJob_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.svip.osp.service.BaseResult doCancelSvipUser(com.vip.svip.osp.service.DoCancelRequest request_) {
				
				send_doCancelSvipUser(request_);
				return recv_doCancelSvipUser(); 
				
			}
			
			
			private void send_doCancelSvipUser(com.vip.svip.osp.service.DoCancelRequest request_){
				
				InitInvocation("doCancelSvipUser");
				
				doCancelSvipUser_args args = new doCancelSvipUser_args();
				args.SetRequest(request_);
				
				SendBase(args, doCancelSvipUser_argsHelper.getInstance());
			}
			
			
			private com.vip.svip.osp.service.BaseResult recv_doCancelSvipUser(){
				
				doCancelSvipUser_result result = new doCancelSvipUser_result();
				ReceiveBase(result, doCancelSvipUser_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public string draw(com.vip.svip.osp.service.DrawRequest request_) {
				
				send_draw(request_);
				return recv_draw(); 
				
			}
			
			
			private void send_draw(com.vip.svip.osp.service.DrawRequest request_){
				
				InitInvocation("draw");
				
				draw_args args = new draw_args();
				args.SetRequest(request_);
				
				SendBase(args, draw_argsHelper.getInstance());
			}
			
			
			private string recv_draw(){
				
				draw_result result = new draw_result();
				ReceiveBase(result, draw_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.svip.osp.service.AccountInfoResult getBindAccountInfo(com.vip.svip.osp.service.GetBindAccountRequest request_) {
				
				send_getBindAccountInfo(request_);
				return recv_getBindAccountInfo(); 
				
			}
			
			
			private void send_getBindAccountInfo(com.vip.svip.osp.service.GetBindAccountRequest request_){
				
				InitInvocation("getBindAccountInfo");
				
				getBindAccountInfo_args args = new getBindAccountInfo_args();
				args.SetRequest(request_);
				
				SendBase(args, getBindAccountInfo_argsHelper.getInstance());
			}
			
			
			private com.vip.svip.osp.service.AccountInfoResult recv_getBindAccountInfo(){
				
				getBindAccountInfo_result result = new getBindAccountInfo_result();
				ReceiveBase(result, getBindAccountInfo_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.svip.osp.service.BrandGiftIdResult getBrandGiftIdList(com.vip.svip.osp.service.BrandGiftRequest request_) {
				
				send_getBrandGiftIdList(request_);
				return recv_getBrandGiftIdList(); 
				
			}
			
			
			private void send_getBrandGiftIdList(com.vip.svip.osp.service.BrandGiftRequest request_){
				
				InitInvocation("getBrandGiftIdList");
				
				getBrandGiftIdList_args args = new getBrandGiftIdList_args();
				args.SetRequest(request_);
				
				SendBase(args, getBrandGiftIdList_argsHelper.getInstance());
			}
			
			
			private com.vip.svip.osp.service.BrandGiftIdResult recv_getBrandGiftIdList(){
				
				getBrandGiftIdList_result result = new getBrandGiftIdList_result();
				ReceiveBase(result, getBrandGiftIdList_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.svip.osp.service.BuyLimitResult getBuyLimitResult(com.vip.svip.osp.service.BuyLimitRequestHeader header_,com.vip.svip.osp.service.BuyLimitRequestParam param_) {
				
				send_getBuyLimitResult(header_,param_);
				return recv_getBuyLimitResult(); 
				
			}
			
			
			private void send_getBuyLimitResult(com.vip.svip.osp.service.BuyLimitRequestHeader header_,com.vip.svip.osp.service.BuyLimitRequestParam param_){
				
				InitInvocation("getBuyLimitResult");
				
				getBuyLimitResult_args args = new getBuyLimitResult_args();
				args.SetHeader(header_);
				args.SetParam(param_);
				
				SendBase(args, getBuyLimitResult_argsHelper.getInstance());
			}
			
			
			private com.vip.svip.osp.service.BuyLimitResult recv_getBuyLimitResult(){
				
				getBuyLimitResult_result result = new getBuyLimitResult_result();
				ReceiveBase(result, getBuyLimitResult_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.svip.osp.service.GetGoodsIdByPickNoResult getGoodsIdByPickNo(com.vip.svip.osp.service.GetGoodsIdByPickNoReq request_) {
				
				send_getGoodsIdByPickNo(request_);
				return recv_getGoodsIdByPickNo(); 
				
			}
			
			
			private void send_getGoodsIdByPickNo(com.vip.svip.osp.service.GetGoodsIdByPickNoReq request_){
				
				InitInvocation("getGoodsIdByPickNo");
				
				getGoodsIdByPickNo_args args = new getGoodsIdByPickNo_args();
				args.SetRequest(request_);
				
				SendBase(args, getGoodsIdByPickNo_argsHelper.getInstance());
			}
			
			
			private com.vip.svip.osp.service.GetGoodsIdByPickNoResult recv_getGoodsIdByPickNo(){
				
				getGoodsIdByPickNo_result result = new getGoodsIdByPickNo_result();
				ReceiveBase(result, getGoodsIdByPickNo_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.svip.osp.service.GroupValues> getGroupValuesConf(com.vip.svip.osp.service.GetGroupValuesRequest request_) {
				
				send_getGroupValuesConf(request_);
				return recv_getGroupValuesConf(); 
				
			}
			
			
			private void send_getGroupValuesConf(com.vip.svip.osp.service.GetGroupValuesRequest request_){
				
				InitInvocation("getGroupValuesConf");
				
				getGroupValuesConf_args args = new getGroupValuesConf_args();
				args.SetRequest(request_);
				
				SendBase(args, getGroupValuesConf_argsHelper.getInstance());
			}
			
			
			private List<com.vip.svip.osp.service.GroupValues> recv_getGroupValuesConf(){
				
				getGroupValuesConf_result result = new getGroupValuesConf_result();
				ReceiveBase(result, getGroupValuesConf_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.svip.osp.service.GetOpGoodsDetailResult getOpGoodsDetailList(com.vip.svip.osp.service.GetOpGoodsDetailRequest request_) {
				
				send_getOpGoodsDetailList(request_);
				return recv_getOpGoodsDetailList(); 
				
			}
			
			
			private void send_getOpGoodsDetailList(com.vip.svip.osp.service.GetOpGoodsDetailRequest request_){
				
				InitInvocation("getOpGoodsDetailList");
				
				getOpGoodsDetailList_args args = new getOpGoodsDetailList_args();
				args.SetRequest(request_);
				
				SendBase(args, getOpGoodsDetailList_argsHelper.getInstance());
			}
			
			
			private com.vip.svip.osp.service.GetOpGoodsDetailResult recv_getOpGoodsDetailList(){
				
				getOpGoodsDetailList_result result = new getOpGoodsDetailList_result();
				ReceiveBase(result, getOpGoodsDetailList_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.svip.osp.service.GetOpGoodsIdResult getOpGoodsIds(com.vip.svip.osp.service.GetOpGoodsIdRequest request_) {
				
				send_getOpGoodsIds(request_);
				return recv_getOpGoodsIds(); 
				
			}
			
			
			private void send_getOpGoodsIds(com.vip.svip.osp.service.GetOpGoodsIdRequest request_){
				
				InitInvocation("getOpGoodsIds");
				
				getOpGoodsIds_args args = new getOpGoodsIds_args();
				args.SetRequest(request_);
				
				SendBase(args, getOpGoodsIds_argsHelper.getInstance());
			}
			
			
			private com.vip.svip.osp.service.GetOpGoodsIdResult recv_getOpGoodsIds(){
				
				getOpGoodsIds_result result = new getOpGoodsIds_result();
				ReceiveBase(result, getOpGoodsIds_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.svip.osp.service.BrandGoodsPriceResult getPmsPriceByProductId(com.vip.svip.osp.service.BrandGoodsPriceRequest request_) {
				
				send_getPmsPriceByProductId(request_);
				return recv_getPmsPriceByProductId(); 
				
			}
			
			
			private void send_getPmsPriceByProductId(com.vip.svip.osp.service.BrandGoodsPriceRequest request_){
				
				InitInvocation("getPmsPriceByProductId");
				
				getPmsPriceByProductId_args args = new getPmsPriceByProductId_args();
				args.SetRequest(request_);
				
				SendBase(args, getPmsPriceByProductId_argsHelper.getInstance());
			}
			
			
			private com.vip.svip.osp.service.BrandGoodsPriceResult recv_getPmsPriceByProductId(){
				
				getPmsPriceByProductId_result result = new getPmsPriceByProductId_result();
				ReceiveBase(result, getPmsPriceByProductId_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public string getSumCount(com.vip.svip.osp.service.GetSumCountRequest request_) {
				
				send_getSumCount(request_);
				return recv_getSumCount(); 
				
			}
			
			
			private void send_getSumCount(com.vip.svip.osp.service.GetSumCountRequest request_){
				
				InitInvocation("getSumCount");
				
				getSumCount_args args = new getSumCount_args();
				args.SetRequest(request_);
				
				SendBase(args, getSumCount_argsHelper.getInstance());
			}
			
			
			private string recv_getSumCount(){
				
				getSumCount_result result = new getSumCount_result();
				ReceiveBase(result, getSumCount_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public string getSvipBindInfo() {
				
				send_getSvipBindInfo();
				return recv_getSvipBindInfo(); 
				
			}
			
			
			private void send_getSvipBindInfo(){
				
				InitInvocation("getSvipBindInfo");
				
				getSvipBindInfo_args args = new getSvipBindInfo_args();
				
				SendBase(args, getSvipBindInfo_argsHelper.getInstance());
			}
			
			
			private string recv_getSvipBindInfo(){
				
				getSvipBindInfo_result result = new getSvipBindInfo_result();
				ReceiveBase(result, getSvipBindInfo_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.svip.osp.service.SvipBindInfo> getSvipBindInfoByUserId(long? userId_) {
				
				send_getSvipBindInfoByUserId(userId_);
				return recv_getSvipBindInfoByUserId(); 
				
			}
			
			
			private void send_getSvipBindInfoByUserId(long? userId_){
				
				InitInvocation("getSvipBindInfoByUserId");
				
				getSvipBindInfoByUserId_args args = new getSvipBindInfoByUserId_args();
				args.SetUserId(userId_);
				
				SendBase(args, getSvipBindInfoByUserId_argsHelper.getInstance());
			}
			
			
			private List<com.vip.svip.osp.service.SvipBindInfo> recv_getSvipBindInfoByUserId(){
				
				getSvipBindInfoByUserId_result result = new getSvipBindInfoByUserId_result();
				ReceiveBase(result, getSvipBindInfoByUserId_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.svip.osp.service.GetSvipGoodsResult getSvipGoodsByMid(com.vip.svip.osp.service.GetSvipGoodsRequest request_) {
				
				send_getSvipGoodsByMid(request_);
				return recv_getSvipGoodsByMid(); 
				
			}
			
			
			private void send_getSvipGoodsByMid(com.vip.svip.osp.service.GetSvipGoodsRequest request_){
				
				InitInvocation("getSvipGoodsByMid");
				
				getSvipGoodsByMid_args args = new getSvipGoodsByMid_args();
				args.SetRequest(request_);
				
				SendBase(args, getSvipGoodsByMid_argsHelper.getInstance());
			}
			
			
			private com.vip.svip.osp.service.GetSvipGoodsResult recv_getSvipGoodsByMid(){
				
				getSvipGoodsByMid_result result = new getSvipGoodsByMid_result();
				ReceiveBase(result, getSvipGoodsByMid_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.svip.osp.service.GetSvipGoodsDetailResult getSvipGoodsDetail(com.vip.svip.osp.service.GetSvipGoodsDetailReq request_) {
				
				send_getSvipGoodsDetail(request_);
				return recv_getSvipGoodsDetail(); 
				
			}
			
			
			private void send_getSvipGoodsDetail(com.vip.svip.osp.service.GetSvipGoodsDetailReq request_){
				
				InitInvocation("getSvipGoodsDetail");
				
				getSvipGoodsDetail_args args = new getSvipGoodsDetail_args();
				args.SetRequest(request_);
				
				SendBase(args, getSvipGoodsDetail_argsHelper.getInstance());
			}
			
			
			private com.vip.svip.osp.service.GetSvipGoodsDetailResult recv_getSvipGoodsDetail(){
				
				getSvipGoodsDetail_result result = new getSvipGoodsDetail_result();
				ReceiveBase(result, getSvipGoodsDetail_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.svip.osp.service.GetSvipInfo4AppClubResult getSvipInfo4AppClub(com.vip.svip.osp.service.GetSvipInfo4AppClubRequest request_) {
				
				send_getSvipInfo4AppClub(request_);
				return recv_getSvipInfo4AppClub(); 
				
			}
			
			
			private void send_getSvipInfo4AppClub(com.vip.svip.osp.service.GetSvipInfo4AppClubRequest request_){
				
				InitInvocation("getSvipInfo4AppClub");
				
				getSvipInfo4AppClub_args args = new getSvipInfo4AppClub_args();
				args.SetRequest(request_);
				
				SendBase(args, getSvipInfo4AppClub_argsHelper.getInstance());
			}
			
			
			private com.vip.svip.osp.service.GetSvipInfo4AppClubResult recv_getSvipInfo4AppClub(){
				
				getSvipInfo4AppClub_result result = new getSvipInfo4AppClub_result();
				ReceiveBase(result, getSvipInfo4AppClub_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.svip.osp.service.KTBaseInfoResult getSvipMainInfo(com.vip.svip.osp.service.BaseRequestHeader header_) {
				
				send_getSvipMainInfo(header_);
				return recv_getSvipMainInfo(); 
				
			}
			
			
			private void send_getSvipMainInfo(com.vip.svip.osp.service.BaseRequestHeader header_){
				
				InitInvocation("getSvipMainInfo");
				
				getSvipMainInfo_args args = new getSvipMainInfo_args();
				args.SetHeader(header_);
				
				SendBase(args, getSvipMainInfo_argsHelper.getInstance());
			}
			
			
			private com.vip.svip.osp.service.KTBaseInfoResult recv_getSvipMainInfo(){
				
				getSvipMainInfo_result result = new getSvipMainInfo_result();
				ReceiveBase(result, getSvipMainInfo_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.svip.osp.service.SvipUserHealthResp getSvipUserHealth(com.vip.svip.osp.service.GetSvipUserHealthReq req_) {
				
				send_getSvipUserHealth(req_);
				return recv_getSvipUserHealth(); 
				
			}
			
			
			private void send_getSvipUserHealth(com.vip.svip.osp.service.GetSvipUserHealthReq req_){
				
				InitInvocation("getSvipUserHealth");
				
				getSvipUserHealth_args args = new getSvipUserHealth_args();
				args.SetReq(req_);
				
				SendBase(args, getSvipUserHealth_argsHelper.getInstance());
			}
			
			
			private com.vip.svip.osp.service.SvipUserHealthResp recv_getSvipUserHealth(){
				
				getSvipUserHealth_result result = new getSvipUserHealth_result();
				ReceiveBase(result, getSvipUserHealth_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.svip.osp.service.SvipUserLimitStateResp getSvipUserInfo(com.vip.svip.osp.service.SvipUserLimitStateReq req_) {
				
				send_getSvipUserInfo(req_);
				return recv_getSvipUserInfo(); 
				
			}
			
			
			private void send_getSvipUserInfo(com.vip.svip.osp.service.SvipUserLimitStateReq req_){
				
				InitInvocation("getSvipUserInfo");
				
				getSvipUserInfo_args args = new getSvipUserInfo_args();
				args.SetReq(req_);
				
				SendBase(args, getSvipUserInfo_argsHelper.getInstance());
			}
			
			
			private com.vip.svip.osp.service.SvipUserLimitStateResp recv_getSvipUserInfo(){
				
				getSvipUserInfo_result result = new getSvipUserInfo_result();
				ReceiveBase(result, getSvipUserInfo_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.svip.osp.service.TencentSvipGoodsInfo getTencentVipSvipCardInfo(long? userId_) {
				
				send_getTencentVipSvipCardInfo(userId_);
				return recv_getTencentVipSvipCardInfo(); 
				
			}
			
			
			private void send_getTencentVipSvipCardInfo(long? userId_){
				
				InitInvocation("getTencentVipSvipCardInfo");
				
				getTencentVipSvipCardInfo_args args = new getTencentVipSvipCardInfo_args();
				args.SetUserId(userId_);
				
				SendBase(args, getTencentVipSvipCardInfo_argsHelper.getInstance());
			}
			
			
			private com.vip.svip.osp.service.TencentSvipGoodsInfo recv_getTencentVipSvipCardInfo(){
				
				getTencentVipSvipCardInfo_result result = new getTencentVipSvipCardInfo_result();
				ReceiveBase(result, getTencentVipSvipCardInfo_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.svip.osp.service.GetTheTimeSvipPriceResult getTheTimeSvipPrice(com.vip.svip.osp.service.GetTheTimeSvipPrice request_) {
				
				send_getTheTimeSvipPrice(request_);
				return recv_getTheTimeSvipPrice(); 
				
			}
			
			
			private void send_getTheTimeSvipPrice(com.vip.svip.osp.service.GetTheTimeSvipPrice request_){
				
				InitInvocation("getTheTimeSvipPrice");
				
				getTheTimeSvipPrice_args args = new getTheTimeSvipPrice_args();
				args.SetRequest(request_);
				
				SendBase(args, getTheTimeSvipPrice_argsHelper.getInstance());
			}
			
			
			private com.vip.svip.osp.service.GetTheTimeSvipPriceResult recv_getTheTimeSvipPrice(){
				
				getTheTimeSvipPrice_result result = new getTheTimeSvipPrice_result();
				ReceiveBase(result, getTheTimeSvipPrice_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public string getUserAttendInfo(com.vip.svip.osp.service.UserAttendInfoRequest request_) {
				
				send_getUserAttendInfo(request_);
				return recv_getUserAttendInfo(); 
				
			}
			
			
			private void send_getUserAttendInfo(com.vip.svip.osp.service.UserAttendInfoRequest request_){
				
				InitInvocation("getUserAttendInfo");
				
				getUserAttendInfo_args args = new getUserAttendInfo_args();
				args.SetRequest(request_);
				
				SendBase(args, getUserAttendInfo_argsHelper.getInstance());
			}
			
			
			private string recv_getUserAttendInfo(){
				
				getUserAttendInfo_result result = new getUserAttendInfo_result();
				ReceiveBase(result, getUserAttendInfo_resultHelper.getInstance());
				
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
			
			
			public string isSvipBanArea(string areaId_) {
				
				send_isSvipBanArea(areaId_);
				return recv_isSvipBanArea(); 
				
			}
			
			
			private void send_isSvipBanArea(string areaId_){
				
				InitInvocation("isSvipBanArea");
				
				isSvipBanArea_args args = new isSvipBanArea_args();
				args.SetAreaId(areaId_);
				
				SendBase(args, isSvipBanArea_argsHelper.getInstance());
			}
			
			
			private string recv_isSvipBanArea(){
				
				isSvipBanArea_result result = new isSvipBanArea_result();
				ReceiveBase(result, isSvipBanArea_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.svip.osp.service.BuyLimitResult isSvipBuyLimit(com.vip.svip.osp.service.BuyLimitRequestHeader header_,com.vip.svip.osp.service.BuyLimitRequestParam param_) {
				
				send_isSvipBuyLimit(header_,param_);
				return recv_isSvipBuyLimit(); 
				
			}
			
			
			private void send_isSvipBuyLimit(com.vip.svip.osp.service.BuyLimitRequestHeader header_,com.vip.svip.osp.service.BuyLimitRequestParam param_){
				
				InitInvocation("isSvipBuyLimit");
				
				isSvipBuyLimit_args args = new isSvipBuyLimit_args();
				args.SetHeader(header_);
				args.SetParam(param_);
				
				SendBase(args, isSvipBuyLimit_argsHelper.getInstance());
			}
			
			
			private com.vip.svip.osp.service.BuyLimitResult recv_isSvipBuyLimit(){
				
				isSvipBuyLimit_result result = new isSvipBuyLimit_result();
				ReceiveBase(result, isSvipBuyLimit_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.svip.osp.service.BuyLimitState isSvipLimitUser(com.vip.svip.osp.service.BuyLimitStateRequest request_) {
				
				send_isSvipLimitUser(request_);
				return recv_isSvipLimitUser(); 
				
			}
			
			
			private void send_isSvipLimitUser(com.vip.svip.osp.service.BuyLimitStateRequest request_){
				
				InitInvocation("isSvipLimitUser");
				
				isSvipLimitUser_args args = new isSvipLimitUser_args();
				args.SetRequest(request_);
				
				SendBase(args, isSvipLimitUser_argsHelper.getInstance());
			}
			
			
			private com.vip.svip.osp.service.BuyLimitState recv_isSvipLimitUser(){
				
				isSvipLimitUser_result result = new isSvipLimitUser_result();
				ReceiveBase(result, isSvipLimitUser_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.svip.osp.service.BuyLimitState isSvipLimitUserByPhone(com.vip.svip.osp.service.CheckSvipUserLimitByPhoneParam request_) {
				
				send_isSvipLimitUserByPhone(request_);
				return recv_isSvipLimitUserByPhone(); 
				
			}
			
			
			private void send_isSvipLimitUserByPhone(com.vip.svip.osp.service.CheckSvipUserLimitByPhoneParam request_){
				
				InitInvocation("isSvipLimitUserByPhone");
				
				isSvipLimitUserByPhone_args args = new isSvipLimitUserByPhone_args();
				args.SetRequest(request_);
				
				SendBase(args, isSvipLimitUserByPhone_argsHelper.getInstance());
			}
			
			
			private com.vip.svip.osp.service.BuyLimitState recv_isSvipLimitUserByPhone(){
				
				isSvipLimitUserByPhone_result result = new isSvipLimitUserByPhone_result();
				ReceiveBase(result, isSvipLimitUserByPhone_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.svip.osp.service.DoubleSvipCreateResponse joinSvipForTencentVideoSide(com.vip.svip.osp.service.DoubleSvipRequest request_) {
				
				send_joinSvipForTencentVideoSide(request_);
				return recv_joinSvipForTencentVideoSide(); 
				
			}
			
			
			private void send_joinSvipForTencentVideoSide(com.vip.svip.osp.service.DoubleSvipRequest request_){
				
				InitInvocation("joinSvipForTencentVideoSide");
				
				joinSvipForTencentVideoSide_args args = new joinSvipForTencentVideoSide_args();
				args.SetRequest(request_);
				
				SendBase(args, joinSvipForTencentVideoSide_argsHelper.getInstance());
			}
			
			
			private com.vip.svip.osp.service.DoubleSvipCreateResponse recv_joinSvipForTencentVideoSide(){
				
				joinSvipForTencentVideoSide_result result = new joinSvipForTencentVideoSide_result();
				ReceiveBase(result, joinSvipForTencentVideoSide_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.svip.osp.service.BaseResult joinTencentVideoMemberAtVipSide(com.vip.svip.osp.service.DoubleSvipRequest request_) {
				
				send_joinTencentVideoMemberAtVipSide(request_);
				return recv_joinTencentVideoMemberAtVipSide(); 
				
			}
			
			
			private void send_joinTencentVideoMemberAtVipSide(com.vip.svip.osp.service.DoubleSvipRequest request_){
				
				InitInvocation("joinTencentVideoMemberAtVipSide");
				
				joinTencentVideoMemberAtVipSide_args args = new joinTencentVideoMemberAtVipSide_args();
				args.SetRequest(request_);
				
				SendBase(args, joinTencentVideoMemberAtVipSide_argsHelper.getInstance());
			}
			
			
			private com.vip.svip.osp.service.BaseResult recv_joinTencentVideoMemberAtVipSide(){
				
				joinTencentVideoMemberAtVipSide_result result = new joinTencentVideoMemberAtVipSide_result();
				ReceiveBase(result, joinTencentVideoMemberAtVipSide_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.svip.osp.service.BaseResult offlineChannelTrySvip(com.vip.svip.osp.service.SimpleRequestHeader header_,com.vip.svip.osp.service.OfflineChannelInfo channelInfo_) {
				
				send_offlineChannelTrySvip(header_,channelInfo_);
				return recv_offlineChannelTrySvip(); 
				
			}
			
			
			private void send_offlineChannelTrySvip(com.vip.svip.osp.service.SimpleRequestHeader header_,com.vip.svip.osp.service.OfflineChannelInfo channelInfo_){
				
				InitInvocation("offlineChannelTrySvip");
				
				offlineChannelTrySvip_args args = new offlineChannelTrySvip_args();
				args.SetHeader(header_);
				args.SetChannelInfo(channelInfo_);
				
				SendBase(args, offlineChannelTrySvip_argsHelper.getInstance());
			}
			
			
			private com.vip.svip.osp.service.BaseResult recv_offlineChannelTrySvip(){
				
				offlineChannelTrySvip_result result = new offlineChannelTrySvip_result();
				ReceiveBase(result, offlineChannelTrySvip_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.svip.osp.service.BuyLimitResult openLimitCheck(com.vip.svip.osp.service.OpenLimitRequest request_) {
				
				send_openLimitCheck(request_);
				return recv_openLimitCheck(); 
				
			}
			
			
			private void send_openLimitCheck(com.vip.svip.osp.service.OpenLimitRequest request_){
				
				InitInvocation("openLimitCheck");
				
				openLimitCheck_args args = new openLimitCheck_args();
				args.SetRequest(request_);
				
				SendBase(args, openLimitCheck_argsHelper.getInstance());
			}
			
			
			private com.vip.svip.osp.service.BuyLimitResult recv_openLimitCheck(){
				
				openLimitCheck_result result = new openLimitCheck_result();
				ReceiveBase(result, openLimitCheck_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.svip.osp.service.DoubleSvipStatus prepareDoubleSvipAccess(com.vip.svip.osp.service.DoubleSvipRequest request_) {
				
				send_prepareDoubleSvipAccess(request_);
				return recv_prepareDoubleSvipAccess(); 
				
			}
			
			
			private void send_prepareDoubleSvipAccess(com.vip.svip.osp.service.DoubleSvipRequest request_){
				
				InitInvocation("prepareDoubleSvipAccess");
				
				prepareDoubleSvipAccess_args args = new prepareDoubleSvipAccess_args();
				args.SetRequest(request_);
				
				SendBase(args, prepareDoubleSvipAccess_argsHelper.getInstance());
			}
			
			
			private com.vip.svip.osp.service.DoubleSvipStatus recv_prepareDoubleSvipAccess(){
				
				prepareDoubleSvipAccess_result result = new prepareDoubleSvipAccess_result();
				ReceiveBase(result, prepareDoubleSvipAccess_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public string receivePrize(com.vip.svip.osp.service.ReceivePrizeRequest request_) {
				
				send_receivePrize(request_);
				return recv_receivePrize(); 
				
			}
			
			
			private void send_receivePrize(com.vip.svip.osp.service.ReceivePrizeRequest request_){
				
				InitInvocation("receivePrize");
				
				receivePrize_args args = new receivePrize_args();
				args.SetRequest(request_);
				
				SendBase(args, receivePrize_argsHelper.getInstance());
			}
			
			
			private string recv_receivePrize(){
				
				receivePrize_result result = new receivePrize_result();
				ReceiveBase(result, receivePrize_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.svip.osp.service.BaseResult rejoinTencentMember(string serial_,string admin_) {
				
				send_rejoinTencentMember(serial_,admin_);
				return recv_rejoinTencentMember(); 
				
			}
			
			
			private void send_rejoinTencentMember(string serial_,string admin_){
				
				InitInvocation("rejoinTencentMember");
				
				rejoinTencentMember_args args = new rejoinTencentMember_args();
				args.SetSerial(serial_);
				args.SetAdmin(admin_);
				
				SendBase(args, rejoinTencentMember_argsHelper.getInstance());
			}
			
			
			private com.vip.svip.osp.service.BaseResult recv_rejoinTencentMember(){
				
				rejoinTencentMember_result result = new rejoinTencentMember_result();
				ReceiveBase(result, rejoinTencentMember_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public void retryOthersOperateRecord() {
				
				send_retryOthersOperateRecord();
				recv_retryOthersOperateRecord();
				
			}
			
			
			private void send_retryOthersOperateRecord(){
				
				InitInvocation("retryOthersOperateRecord");
				
				retryOthersOperateRecord_args args = new retryOthersOperateRecord_args();
				
				SendBase(args, retryOthersOperateRecord_argsHelper.getInstance());
			}
			
			
			private void recv_retryOthersOperateRecord(){
				
				retryOthersOperateRecord_result result = new retryOthersOperateRecord_result();
				ReceiveBase(result, retryOthersOperateRecord_resultHelper.getInstance());
				
				
			}
			
			
			public void retryProcessGifts() {
				
				send_retryProcessGifts();
				recv_retryProcessGifts();
				
			}
			
			
			private void send_retryProcessGifts(){
				
				InitInvocation("retryProcessGifts");
				
				retryProcessGifts_args args = new retryProcessGifts_args();
				
				SendBase(args, retryProcessGifts_argsHelper.getInstance());
			}
			
			
			private void recv_retryProcessGifts(){
				
				retryProcessGifts_result result = new retryProcessGifts_result();
				ReceiveBase(result, retryProcessGifts_resultHelper.getInstance());
				
				
			}
			
			
			public void retrySvipExceptionLog() {
				
				send_retrySvipExceptionLog();
				recv_retrySvipExceptionLog();
				
			}
			
			
			private void send_retrySvipExceptionLog(){
				
				InitInvocation("retrySvipExceptionLog");
				
				retrySvipExceptionLog_args args = new retrySvipExceptionLog_args();
				
				SendBase(args, retrySvipExceptionLog_argsHelper.getInstance());
			}
			
			
			private void recv_retrySvipExceptionLog(){
				
				retrySvipExceptionLog_result result = new retrySvipExceptionLog_result();
				ReceiveBase(result, retrySvipExceptionLog_resultHelper.getInstance());
				
				
			}
			
			
			public void retrySvipOperate() {
				
				send_retrySvipOperate();
				recv_retrySvipOperate();
				
			}
			
			
			private void send_retrySvipOperate(){
				
				InitInvocation("retrySvipOperate");
				
				retrySvipOperate_args args = new retrySvipOperate_args();
				
				SendBase(args, retrySvipOperate_argsHelper.getInstance());
			}
			
			
			private void recv_retrySvipOperate(){
				
				retrySvipOperate_result result = new retrySvipOperate_result();
				ReceiveBase(result, retrySvipOperate_resultHelper.getInstance());
				
				
			}
			
			
			public string scrapeAction(com.vip.svip.osp.service.ScrapeActionRequest request_) {
				
				send_scrapeAction(request_);
				return recv_scrapeAction(); 
				
			}
			
			
			private void send_scrapeAction(com.vip.svip.osp.service.ScrapeActionRequest request_){
				
				InitInvocation("scrapeAction");
				
				scrapeAction_args args = new scrapeAction_args();
				args.SetRequest(request_);
				
				SendBase(args, scrapeAction_argsHelper.getInstance());
			}
			
			
			private string recv_scrapeAction(){
				
				scrapeAction_result result = new scrapeAction_result();
				ReceiveBase(result, scrapeAction_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.svip.osp.service.SvipTXBindHistoryResult searchSvipTXHistory(com.vip.svip.osp.service.SearchSvipHistoryRequest request_) {
				
				send_searchSvipTXHistory(request_);
				return recv_searchSvipTXHistory(); 
				
			}
			
			
			private void send_searchSvipTXHistory(com.vip.svip.osp.service.SearchSvipHistoryRequest request_){
				
				InitInvocation("searchSvipTXHistory");
				
				searchSvipTXHistory_args args = new searchSvipTXHistory_args();
				args.SetRequest(request_);
				
				SendBase(args, searchSvipTXHistory_argsHelper.getInstance());
			}
			
			
			private com.vip.svip.osp.service.SvipTXBindHistoryResult recv_searchSvipTXHistory(){
				
				searchSvipTXHistory_result result = new searchSvipTXHistory_result();
				ReceiveBase(result, searchSvipTXHistory_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.svip.osp.service.BaseResult specialMemberTrySvip(com.vip.svip.osp.service.SimpleRequestHeader header_) {
				
				send_specialMemberTrySvip(header_);
				return recv_specialMemberTrySvip(); 
				
			}
			
			
			private void send_specialMemberTrySvip(com.vip.svip.osp.service.SimpleRequestHeader header_){
				
				InitInvocation("specialMemberTrySvip");
				
				specialMemberTrySvip_args args = new specialMemberTrySvip_args();
				args.SetHeader(header_);
				
				SendBase(args, specialMemberTrySvip_argsHelper.getInstance());
			}
			
			
			private com.vip.svip.osp.service.BaseResult recv_specialMemberTrySvip(){
				
				specialMemberTrySvip_result result = new specialMemberTrySvip_result();
				ReceiveBase(result, specialMemberTrySvip_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.svip.osp.service.SvipOperateResult svipUserOperate(com.vip.svip.osp.service.SvipUserOperateInfoParam info_,com.vip.svip.osp.service.SvipUserOperateSignCheck signCheck_) {
				
				send_svipUserOperate(info_,signCheck_);
				return recv_svipUserOperate(); 
				
			}
			
			
			private void send_svipUserOperate(com.vip.svip.osp.service.SvipUserOperateInfoParam info_,com.vip.svip.osp.service.SvipUserOperateSignCheck signCheck_){
				
				InitInvocation("svipUserOperate");
				
				svipUserOperate_args args = new svipUserOperate_args();
				args.SetInfo(info_);
				args.SetSignCheck(signCheck_);
				
				SendBase(args, svipUserOperate_argsHelper.getInstance());
			}
			
			
			private com.vip.svip.osp.service.SvipOperateResult recv_svipUserOperate(){
				
				svipUserOperate_result result = new svipUserOperate_result();
				ReceiveBase(result, svipUserOperate_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public void syncCancelResult() {
				
				send_syncCancelResult();
				recv_syncCancelResult();
				
			}
			
			
			private void send_syncCancelResult(){
				
				InitInvocation("syncCancelResult");
				
				syncCancelResult_args args = new syncCancelResult_args();
				
				SendBase(args, syncCancelResult_argsHelper.getInstance());
			}
			
			
			private void recv_syncCancelResult(){
				
				syncCancelResult_result result = new syncCancelResult_result();
				ReceiveBase(result, syncCancelResult_resultHelper.getInstance());
				
				
			}
			
			
			public com.vip.svip.osp.service.TxGetSvipTokenResult txGetSvipToken(com.vip.svip.osp.service.TxGetTokenRequest request_) {
				
				send_txGetSvipToken(request_);
				return recv_txGetSvipToken(); 
				
			}
			
			
			private void send_txGetSvipToken(com.vip.svip.osp.service.TxGetTokenRequest request_){
				
				InitInvocation("txGetSvipToken");
				
				txGetSvipToken_args args = new txGetSvipToken_args();
				args.SetRequest(request_);
				
				SendBase(args, txGetSvipToken_argsHelper.getInstance());
			}
			
			
			private com.vip.svip.osp.service.TxGetSvipTokenResult recv_txGetSvipToken(){
				
				txGetSvipToken_result result = new txGetSvipToken_result();
				ReceiveBase(result, txGetSvipToken_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.svip.osp.service.DoubleSvipCreateResponse txOpenSvip(com.vip.svip.osp.service.TxOpenSvipRequest request_) {
				
				send_txOpenSvip(request_);
				return recv_txOpenSvip(); 
				
			}
			
			
			private void send_txOpenSvip(com.vip.svip.osp.service.TxOpenSvipRequest request_){
				
				InitInvocation("txOpenSvip");
				
				txOpenSvip_args args = new txOpenSvip_args();
				args.SetRequest(request_);
				
				SendBase(args, txOpenSvip_argsHelper.getInstance());
			}
			
			
			private com.vip.svip.osp.service.DoubleSvipCreateResponse recv_txOpenSvip(){
				
				txOpenSvip_result result = new txOpenSvip_result();
				ReceiveBase(result, txOpenSvip_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.svip.osp.service.SvipOperateResult vOrderCallSvip(string json_) {
				
				send_vOrderCallSvip(json_);
				return recv_vOrderCallSvip(); 
				
			}
			
			
			private void send_vOrderCallSvip(string json_){
				
				InitInvocation("vOrderCallSvip");
				
				vOrderCallSvip_args args = new vOrderCallSvip_args();
				args.SetJson(json_);
				
				SendBase(args, vOrderCallSvip_argsHelper.getInstance());
			}
			
			
			private com.vip.svip.osp.service.SvipOperateResult recv_vOrderCallSvip(){
				
				vOrderCallSvip_result result = new vOrderCallSvip_result();
				ReceiveBase(result, vOrderCallSvip_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}