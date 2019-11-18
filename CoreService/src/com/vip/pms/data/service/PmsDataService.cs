using System;
using System.Collections.Generic;

namespace com.vip.pms.data.service{
	
	
	public interface PmsDataService {
		
		
		bool? addActivityUserLog( com.vip.pms.data.service.ActivityUserLogRequestModel request_ );
		
		bool? addCommandPersonalCode( string commandId_,   string personalCode_ );
		
		bool? addCommandUserLog( com.vip.pms.data.service.CommandUserLogRequestModel request_ );
		
		bool? addCouponUserLog( com.vip.pms.data.service.CouponOrderRequestModel request_ );
		
		bool? addOldPmsOrderInfo( com.vip.pms.data.service.OldPmsOrderRequestModel request_ );
		
		com.vip.pms.data.service.SyncResult addOrUpdateActivitySync( com.vip.pms.data.service.ActivityRequestModel activityRequestModel_ );
		
		com.vip.pms.data.service.SyncResult addOrUpdateCommandSync( com.vip.pms.data.service.CommandRequestModel commandRequestModel_ );
		
		bool? addOrUpdateConfig( com.vip.pms.data.service.AdminConfigModel config_ );
		
		com.vip.pms.data.service.SyncResult addOrUpdateCouponGroupSync( com.vip.pms.data.service.CouponRequestModel couponRequestModel_ );
		
		com.vip.pms.data.service.SyncResult addOrUpdateCouponRuleSync( com.vip.pms.data.service.CouponRuleRequestModel couponRuleRequestModel_ );
		
		com.vip.pms.data.service.SyncResult addOrUpdateCouponSync( com.vip.pms.data.service.CouponRequestModel couponRequestModel_ );
		
		com.vip.pms.data.service.SyncResult addOrUpdatePaySync( com.vip.pms.data.service.PayRequestModel payRequestModel_ );
		
		com.vip.pms.data.service.SyncResult addOrUpdatePrepayInfoSync( com.vip.pms.data.service.PrepayInfoRequestModel prepayInfoRequestModel_ );
		
		com.vip.pms.data.service.SyncResult addOrUpdateSpecialSync( com.vip.pms.data.service.SpecialRequestModel specialRequestModel_ );
		
		void addOrUpdateSurprisePriceActivitySync( com.vip.pms.data.service.SurprisePriceActivityRequestModel activityRequestModel_ );
		
		bool? addPayUserLog( com.vip.pms.data.service.PayUserLogRequestModel request_ );
		
		bool? addSpecialUserLog( com.vip.pms.data.service.SpecialUserLogRequestModel request_ );
		
		com.vip.pms.data.service.SyncResult batchModifyCouponTime( List<com.vip.pms.data.service.ModifyInfoRequestModel> modifyList_,   string taskId_ );
		
		bool? buildAllActivityIndex( string indexType_ );
		
		com.vip.pms.data.service.SyncResult cancelActivitySync( List<string> actNoList_,   long? channelId_ );
		
		com.vip.pms.data.service.SyncResult cancelCommandSync( List<string> commandNoList_ );
		
		com.vip.pms.data.service.SyncResult cancelOrOfflineCouponGroupSync( List<string> noList_,   bool isCancel_ );
		
		com.vip.pms.data.service.SyncResult cancelOrOfflineCouponRuleSync( List<string> noList_,   bool isCancel_ );
		
		com.vip.pms.data.service.SyncResult cancelOrOfflineCouponSync( List<string> noList_,   bool isCancel_ );
		
		bool? cancelOrder( string orderNo_,   byte refIdType_,   List<long?> refIdList_,   long? userId_ );
		
		com.vip.pms.data.service.SyncResult cancelPaySync( List<string> payNoList_ );
		
		com.vip.pms.data.service.SyncResult cancelSpecialSync( List<string> specialNoList_ );
		
		void cancelSurprisePriceActivitySync( List<string> actNoList_ );
		
		com.vip.pms.data.service.CheckResult check( com.vip.pms.data.service.CheckRequest checkRequest_ );
		
		com.vip.pms.data.service.CouponResResult couponActivate( com.vip.pms.data.service.CouponInstanceModel instanceModel_ );
		
		com.vip.pms.data.service.CouponResResult couponBind( com.vip.pms.data.service.CouponInstanceModel instanceModel_ );
		
		com.vip.pms.data.service.CouponResResult couponGroupActivate( com.vip.pms.data.service.CouponInstanceModel groupInstanceModel_,   List<com.vip.pms.data.service.CouponInstanceModel> couponInstanceList_ );
		
		com.vip.pms.data.service.CouponResResult couponGroupBind( com.vip.pms.data.service.CouponInstanceModel groupInstanceModel_,   List<com.vip.pms.data.service.CouponInstanceModel> couponInstanceList_ );
		
		void delGoodsOriginalPrice( List<string> spuIdList_ );
		
		void delGoodsSurprisePrice( List<com.vip.pms.data.service.FlushGoodsSurprisePriceModel> modelList_ );
		
		bool? deleteConfig( string type_,   string key_ );
		
		com.vip.pms.data.service.SyncResult deletePrepayInfoByMidSync( string prepayMainNo_,   List<long?> merchandiseNos_ );
		
		com.vip.pms.data.service.SyncResult deletePrepayInfoSync( List<string> prepayMainNos_ );
		
		List<com.vip.pms.data.service.ExportRespModel> exportCoupon( string couponNo_,   long offset_ );
		
		List<com.vip.pms.data.service.ExportRespModel> exportCouponGroup( string groupNo_,   long offset_ );
		
		com.vip.pms.data.service.OrderNosResult fetchCommandOrderNos( com.vip.pms.data.service.FetchCommandOrderNosRequestModel fetchCommandOrderNosRequestModel_ );
		
		com.vip.pms.data.service.OrderResult fetchOrder( com.vip.pms.data.service.FetchOrderRequestModel fetchOrderRequestModel_ );
		
		com.vip.pms.data.service.SyncResult flushCouponRuleIndexSync();
		
		void flushGoodsOriginalPrice( List<com.vip.pms.data.service.FlushGoodsOriginalPriceModel> modelList_ );
		
		void flushGoodsSurprisePrice( List<com.vip.pms.data.service.FlushGoodsSurprisePriceModel> modelList_ );
		
		List<com.vip.pms.data.service.AdminConfigModel> getConfig( string type_,   string key_ );
		
		List<com.vip.pms.data.service.AdminConfigModel> getTypeConfig( string type_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		bool? modifyCacheSwitchStatus( com.vip.pms.data.enums.SwitchStatus? switchStatus_ );
		
		com.vip.pms.data.service.SyncResult modifyCouponTime( int couponId_,   long beginTime_,   long endTime_,   string taskId_ );
		
		com.vip.pms.data.service.SyncResult modifyCouponTimeByUserIds( int couponId_,   long beginTime_,   long endTime_,   List<string> userIds_ );
		
		List<com.vip.pms.data.coupon.model.CouponMultiBindResponse> multiBind( com.vip.pms.data.coupon.model.CouponMultiBindRequest multiBindRequest_ );
		
		List<com.vip.pms.data.coupon.model.CouponMultiBindResponse> multiBindSyncMode( com.vip.pms.data.coupon.model.CouponMultiBindRequest multiBindRequest_ );
		
		bool? offlineActivityCallback( List<string> actNoList_ );
		
		com.vip.pms.data.service.SyncResult offlineActivitySync( List<string> actNoList_,   long? channelId_ );
		
		com.vip.pms.data.service.SyncResult offlineCommandSync( List<string> commandNoList_ );
		
		com.vip.pms.data.service.SyncResult offlinePaySync( List<string> payNoList_ );
		
		com.vip.pms.data.service.SyncResult offlinePrepayInfoSync( com.vip.pms.data.service.DeletePrepayInfoModel requestModel_ );
		
		com.vip.pms.data.service.SyncResult offlineSpecialSync( List<string> specialNoList_ );
		
		void offlineSurprisePriceActivitySync( List<string> actNoList_ );
		
		com.vip.pms.data.model.sync.PrepareActivityResult prepareActivity( com.vip.pms.data.model.sync.PrepareActivityRequest request_ );
		
		com.vip.pms.data.model.sync.PrepareActivityResult prepareSpecial( com.vip.pms.data.model.sync.PrepareActivityRequest request_ );
		
		bool? publishRollbackUseCouponMsg( com.vip.pms.data.service.RollbackCouponReqModel reqModel_ );
		
		com.vip.pms.data.service.SyncResult pushOfflineActivities( com.vip.pms.data.service.ActivityRequestModel activityRequestModel_,   Dictionary<string, byte?> subActivityStatus_ );
		
		List<com.vip.pms.data.service.ConfirmationResult> queryConfirmationNo( List<com.vip.pms.data.service.ConfirmationRequest> confirmationRequests_ );
		
		List<com.vip.pms.data.service.CouponInstanceStatResponse> queryCouponInstanceStat( List<string> couponNos_ );
		
		List<com.vip.pms.data.service.OrderFavDetailResult> queryGoodsFavAmount( List<com.vip.pms.data.service.OrderCouponRequest> orderCouponRequests_ );
		
		bool? refreshOrder( string orderNo_,   string hashValue_,   byte refIdType_,   long? userId_ );
		
		bool? returnCoupon( string userId_,   List<string> couponSns_ );
		
		void saveActPromotionObject( com.vip.pms.data.model.sync.ActObjectRequest request_ );
		
		void saveActivity( com.vip.pms.data.service.ActivityRequestModel request_ );
		
		void saveSpecial( com.vip.pms.data.service.SpecialRequestModel request_ );
		
		void saveSpecialPromotionObject( com.vip.pms.data.model.sync.SpecialObjectRequest request_ );
		
		void submitSMSendingRequest( com.vip.pms.data.service.SMSRequestModel smsRequestModel_ );
		
		bool? syncAllActivityIndex( string indexType_ );
		
		bool? syncAllCacheByCacheType( int? cacheType_,   int? scope_ );
		
		void syncAllGoodsOriginalPrice();
		
		void syncAllGoodsSurprisePrice();
		
		bool? syncBiPush( com.vip.pms.data.service.BiPushTypeEnum? biPushType_ );
		
		bool? syncBlacklistNew( List<com.vip.pms.data.service.BlacklistModel> blacklist_ );
		
		bool? syncCacheByActivityNosAndCacheType( List<string> activityNos_,   int? cacheType_,   List<int?> scopes_ );
		
		bool? syncPayBlackList( List<string> blackIds_ );
		
		void updateActPromotionObject( com.vip.pms.data.model.sync.ActObjectUpdateRequest request_ );
		
		void updateActivityBaseInfo( com.vip.pms.data.service.ActivityRequestModel request_ );
		
		void updateSpecialBaseInfo( com.vip.pms.data.service.SpecialRequestModel request_ );
		
		void updateSpecialPromotionObject( com.vip.pms.data.model.sync.ActObjectUpdateRequest request_ );
		
	}
	
}