using System;
using System.Collections.Generic;

namespace com.vip.svip.osp.service{
	
	
	public interface SvipOspServiceV2 {
		
		
		List<com.vip.svip.osp.service.SearchSvipHistoryResult> SearchSvipHistory( com.vip.svip.osp.service.SearchSvipHistoryRequest request_ );
		
		com.vip.svip.osp.service.BatchCancelBaseResult batchCancel( com.vip.svip.osp.service.BatchCancelRequest request_ );
		
		com.vip.svip.osp.service.BatchCancelBaseResult batchCancelV2( com.vip.svip.osp.service.BatchCancelRequestV2 request_ );
		
		com.vip.svip.osp.service.BaseResult bindTxUserAccount( com.vip.svip.osp.service.BindTxAccRequest request_ );
		
		List<com.vip.svip.osp.service.BrandGiftItem> brandGiftDetailList( com.vip.svip.osp.service.BrandGiftDetailRequest request_ );
		
		com.vip.svip.osp.service.BaseResult checkTxAccLimit( com.vip.svip.osp.service.CheckTxAccLimitRequest request_ );
		
		com.vip.svip.osp.service.BaseResult doCancelJob( com.vip.svip.osp.service.DoCancelJobRequest request_ );
		
		com.vip.svip.osp.service.BaseResult doCancelSvipUser( com.vip.svip.osp.service.DoCancelRequest request_ );
		
		string draw( com.vip.svip.osp.service.DrawRequest request_ );
		
		com.vip.svip.osp.service.AccountInfoResult getBindAccountInfo( com.vip.svip.osp.service.GetBindAccountRequest request_ );
		
		com.vip.svip.osp.service.BrandGiftIdResult getBrandGiftIdList( com.vip.svip.osp.service.BrandGiftRequest request_ );
		
		com.vip.svip.osp.service.BuyLimitResult getBuyLimitResult( com.vip.svip.osp.service.BuyLimitRequestHeader header_,   com.vip.svip.osp.service.BuyLimitRequestParam param_ );
		
		com.vip.svip.osp.service.GetGoodsIdByPickNoResult getGoodsIdByPickNo( com.vip.svip.osp.service.GetGoodsIdByPickNoReq request_ );
		
		List<com.vip.svip.osp.service.GroupValues> getGroupValuesConf( com.vip.svip.osp.service.GetGroupValuesRequest request_ );
		
		com.vip.svip.osp.service.GetOpGoodsDetailResult getOpGoodsDetailList( com.vip.svip.osp.service.GetOpGoodsDetailRequest request_ );
		
		com.vip.svip.osp.service.GetOpGoodsIdResult getOpGoodsIds( com.vip.svip.osp.service.GetOpGoodsIdRequest request_ );
		
		com.vip.svip.osp.service.BrandGoodsPriceResult getPmsPriceByProductId( com.vip.svip.osp.service.BrandGoodsPriceRequest request_ );
		
		string getSumCount( com.vip.svip.osp.service.GetSumCountRequest request_ );
		
		string getSvipBindInfo();
		
		List<com.vip.svip.osp.service.SvipBindInfo> getSvipBindInfoByUserId( long? userId_ );
		
		com.vip.svip.osp.service.GetSvipGoodsResult getSvipGoodsByMid( com.vip.svip.osp.service.GetSvipGoodsRequest request_ );
		
		com.vip.svip.osp.service.GetSvipGoodsDetailResult getSvipGoodsDetail( com.vip.svip.osp.service.GetSvipGoodsDetailReq request_ );
		
		com.vip.svip.osp.service.GetSvipInfo4AppClubResult getSvipInfo4AppClub( com.vip.svip.osp.service.GetSvipInfo4AppClubRequest request_ );
		
		com.vip.svip.osp.service.KTBaseInfoResult getSvipMainInfo( com.vip.svip.osp.service.BaseRequestHeader header_ );
		
		com.vip.svip.osp.service.SvipUserHealthResp getSvipUserHealth( com.vip.svip.osp.service.GetSvipUserHealthReq req_ );
		
		com.vip.svip.osp.service.SvipUserLimitStateResp getSvipUserInfo( com.vip.svip.osp.service.SvipUserLimitStateReq req_ );
		
		com.vip.svip.osp.service.TencentSvipGoodsInfo getTencentVipSvipCardInfo( long? userId_ );
		
		com.vip.svip.osp.service.GetTheTimeSvipPriceResult getTheTimeSvipPrice( com.vip.svip.osp.service.GetTheTimeSvipPrice request_ );
		
		string getUserAttendInfo( com.vip.svip.osp.service.UserAttendInfoRequest request_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		string isSvipBanArea( string areaId_ );
		
		com.vip.svip.osp.service.BuyLimitResult isSvipBuyLimit( com.vip.svip.osp.service.BuyLimitRequestHeader header_,   com.vip.svip.osp.service.BuyLimitRequestParam param_ );
		
		com.vip.svip.osp.service.BuyLimitState isSvipLimitUser( com.vip.svip.osp.service.BuyLimitStateRequest request_ );
		
		com.vip.svip.osp.service.BuyLimitState isSvipLimitUserByPhone( com.vip.svip.osp.service.CheckSvipUserLimitByPhoneParam request_ );
		
		com.vip.svip.osp.service.DoubleSvipCreateResponse joinSvipForTencentVideoSide( com.vip.svip.osp.service.DoubleSvipRequest request_ );
		
		com.vip.svip.osp.service.BaseResult joinTencentVideoMemberAtVipSide( com.vip.svip.osp.service.DoubleSvipRequest request_ );
		
		com.vip.svip.osp.service.BaseResult offlineChannelTrySvip( com.vip.svip.osp.service.SimpleRequestHeader header_,   com.vip.svip.osp.service.OfflineChannelInfo channelInfo_ );
		
		com.vip.svip.osp.service.BuyLimitResult openLimitCheck( com.vip.svip.osp.service.OpenLimitRequest request_ );
		
		com.vip.svip.osp.service.DoubleSvipStatus prepareDoubleSvipAccess( com.vip.svip.osp.service.DoubleSvipRequest request_ );
		
		string receivePrize( com.vip.svip.osp.service.ReceivePrizeRequest request_ );
		
		com.vip.svip.osp.service.BaseResult rejoinTencentMember( string serial_,   string admin_ );
		
		void retryOthersOperateRecord();
		
		void retryProcessGifts();
		
		void retrySvipExceptionLog();
		
		void retrySvipOperate();
		
		string scrapeAction( com.vip.svip.osp.service.ScrapeActionRequest request_ );
		
		com.vip.svip.osp.service.SvipTXBindHistoryResult searchSvipTXHistory( com.vip.svip.osp.service.SearchSvipHistoryRequest request_ );
		
		com.vip.svip.osp.service.BaseResult specialMemberTrySvip( com.vip.svip.osp.service.SimpleRequestHeader header_ );
		
		com.vip.svip.osp.service.SvipOperateResult svipUserOperate( com.vip.svip.osp.service.SvipUserOperateInfoParam info_,   com.vip.svip.osp.service.SvipUserOperateSignCheck signCheck_ );
		
		void syncCancelResult();
		
		com.vip.svip.osp.service.TxGetSvipTokenResult txGetSvipToken( com.vip.svip.osp.service.TxGetTokenRequest request_ );
		
		com.vip.svip.osp.service.DoubleSvipCreateResponse txOpenSvip( com.vip.svip.osp.service.TxOpenSvipRequest request_ );
		
		com.vip.svip.osp.service.SvipOperateResult vOrderCallSvip( string json_ );
		
	}
	
}