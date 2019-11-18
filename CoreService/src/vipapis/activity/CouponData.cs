using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.activity{
	
	
	
	
	
	public class CouponData {
		
		///<summary>
		/// 错误码; <br> 401: 登记成功，用户完成注册后可收到优惠券<br>402: 手机领券已经超过系统限流次数<br>403:活动不存在（后台找不到该活动ID或当前时间晚于活动结束时间加25天<br>418:活动已过期（当前时间晚于活动结束时间，且早于或等于活动结束时间加25天）<br>405:手机领券活动找不到优惠券<br>406:同一个手机领券活动，用户只能参加一次<br>407:本手机号已被多个唯品会账号绑定，无法成功领取优惠券<br>408:通过手机号码获取账户系统用户数据失败异常<br>409:通过用户ID去获取用户群分类失败异常<br>410:领取成功，优惠券已派发<br>411:手机领券活动中有优惠券已派发完毕，活动已下线<br>412:派券系统网络异常<br>413:该账户领券次数超过可领券次数<br>414:券不可派发<br>415:无法查询到券信息<br>416:本活动仅限唯品会C类用户（有历史下单记录）参与<br>417:本活动仅限唯品会非C类用户（新用户或无历史下单记录的老用户）参与<br>421:活动已经下线<br>423:活动未开始（当前时间早于活动开始时间）<br>424:获取优惠券余量与消费量比较网络异常<br>425:新客礼品名额已用完<br>426:老客礼品名额已用完<br>427:新客本阶段礼品名额已用完，请下个阶段再来<br>428:老客本阶段礼品名额已用完，请下个阶段再来<br>429:本阶段礼品名额已用完，请下个阶段再来<br>13333:很抱歉，券已领完【01】<br>2131:点击太快啦，请稍后再试~~
		///</summary>
		
		private string error_code_;
		
		///<summary>
		/// 错误信息
		///</summary>
		
		private string error_msg_;
		
		///<summary>
		/// 领券列表
		///</summary>
		
		private List<vipapis.activity.Coupon> coupons_;
		
		public string GetError_code(){
			return this.error_code_;
		}
		
		public void SetError_code(string value){
			this.error_code_ = value;
		}
		public string GetError_msg(){
			return this.error_msg_;
		}
		
		public void SetError_msg(string value){
			this.error_msg_ = value;
		}
		public List<vipapis.activity.Coupon> GetCoupons(){
			return this.coupons_;
		}
		
		public void SetCoupons(List<vipapis.activity.Coupon> value){
			this.coupons_ = value;
		}
		
	}
	
}